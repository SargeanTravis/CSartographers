using CARTOGRAPHERS_V1.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.TileMechanics
{
   class mTile : Tile
   {
        private List<List<List<iResources>>> finalTile;

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

        public mTile(List<List<List<iResources>>> tiles, int id, string name, int tc) : base(tiles, id, name, tc)
        {

        }

        //End Constructors

        //*Sigh* Literally FillTile from everywhere else... but for Monster Tiles
        public override void FillTile()
        {
            List<List<List<iResources>>> tempTile = Tiles;

            List<List<List<iResources>>> ft = new List<List<List<iResources>>>();

            //My somewhat unique way of filling the final tile: creating each list individually and then nesting them when required.
            List<List<iResources>> subtile = new List<List<iResources>>();
            List<iResources> subsubtile = new List<iResources>();



            rNull nv = new rNull();
            rFillable f = new rFillable();

            for (int i = 0; i != tempTile.Count; i++)
            {
                for (int j = 0; j != tempTile[i].Count; j++)
                {
                    for (int k = 0; k != tempTile[j].Count; k++)
                    {
                        if (k.ToString() == nv.ToString())//Do nothing if there should be nothing there.
                        {
                            subsubtile.Add(nv);
                        }
                        else if (k.ToString() == f.ToString())//Do something if something should be there
                        {

                            subsubtile.Add(new rMonster());


                        }
                    }
                    subtile.Add(subsubtile);//Nest this row
                }
                ft.Add(subtile);//Nest this tile rotation
            }

            FinalTile = ft;
        }

        public override void outputTile(int rotation)
        {
            throw new NotImplementedException();
        }
    }
}
