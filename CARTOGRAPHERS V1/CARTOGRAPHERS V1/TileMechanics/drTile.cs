using CARTOGRAPHERS_V1.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.TileMechanics
{

    class DRTile : Tile/*Double Resource Tile*/
    {
        public iResources Resource_One;
        public iResources Resource_Two;

        
        
        //Selector that swaps tile resource types based on what user selects. 'false' will indicate Resource_One is used.
        private bool selected_tile;

        //Begin Constructors

        public List<List<List<iResources>>> FinalTile
        {
            get
            {
                return finalTile;
            }
            set
            {
                finalTile = value;
            }
        }

     

        public bool Selected_Tile
        {
            get
            {
                return selected_tile;
            }
            set
            {
                selected_tile = value;
            }
        }

        public DRTile(List<List<List<iResources>>> ts, int id, string name, int tc, iResources r1, iResources r2, bool selector):base(ts, id, name, tc)
        {
            Resource_One = r1;
            Resource_Two = r2;
            Selected_Tile = selector;

            
        }

        public DRTile copyTo(DRTile tile)
        {
            DRTile newTile = new DRTile(tile.Tiles, tile.Tile_ID, tile.Name, tile.Time, tile.Resource_One, tile.Resource_Two, tile.Selected_Tile);


            return newTile;
        }

        //End Constructors


        //Takes the selected template and fills it with the desired resource type selected.
        //This looks similar to dtTile but is fundamentally different because 
        public override List<List<List<iResources>>> FillTile()
        {
            List<List<List<iResources>>> tempTile = Tiles;

            List<List<List<iResources>>> ft = new List<List<List<iResources>>>();

            //My somewhat unique way of filling the final tile: creating each list individually and then nesting them when required.
            
           



            rNull nv= new rNull();
            rFillable f = new rFillable();

            for(int i =0;i!=tempTile.Count;i++)
            {
                List<List<iResources>> subtile = new List<List<iResources>>();

                for (int j =0; j!=tempTile[i].Count;j++)
                {
                    List<iResources> subsubtile = new List<iResources>();

                    for (int k =0; k!=tempTile[j].Count;k++)
                    {
                        if(k.ToString()==nv.ToString())//Do nothing if there should be nothing there.
                        {
                            

                            subsubtile.Add(new rNull());
                        }
                        else if (k.ToString() == f.ToString())//Do something if something should be there
                        {
                            if(Selected_Tile == false)//Resource 1
                            {
                                
                                
                                subsubtile.Add(Resource_One);//Nest this value
                                

                            }
                            else//Resource 2
                            {
                                subsubtile.Add(Resource_Two);//Nest this value
                            }



                        }
                    }
                    subtile.Add(subsubtile);//Nest this row
                }
                ft.Add(subtile);//Nest this tile rotation
            }

            return ft;
        }



        public override void outputTile(int rotation)
        {

            Console.Write("+");

            FillTile();



        }


        

    }
}
