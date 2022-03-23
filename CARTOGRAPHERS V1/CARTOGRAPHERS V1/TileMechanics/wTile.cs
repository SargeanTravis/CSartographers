using CARTOGRAPHERS_V1.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.TileMechanics
{
    class wTile : Tile//Wild Tile (For Rift Lands/Invalid piece placement)
    {

        private List<List<List<iResources>>> finalTile;
        private int selector;//integer selector instead of boolean due to below comment V

        public readonly iResources[] SELECTOR_ARRAY = { };//WIld Tile can be any legal placable tile in the gaqme, therefore it controls its own tile selection
        public iResources Resource;

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

        public int Selector
        {
            get
            {
                return selector;
            }
            set
            {
                selector = value;
            }
        }

        public wTile(List<List<List<iResources>>> ts, int id, string name, int tc, iResources r): base(ts, id, name, tc)
        {

            Resource = r;

            Selector = SwitchResource();

            FillTile();

        }

        //End Constructors

        public int SwitchResource()
        {

            //TODO: Implement WIldTile's functionality

            return 0;
        }



        //FIllTile probably could have been an abstract override, but too late for that now.
        public override void FillTile()
        {
            List<List<List<iResources>>> ft = new List<List<List<iResources>>>();

            List<List<iResources>> subtile = new List<List<iResources>>();
            List<iResources> subsubtile = new List<iResources>();



            rNull nv = new rNull();
            rFillable f = new rFillable();

            for (int i = 0; i != Tiles.Count; i++)
            {
                for (int j = 0; j != Tiles[i].Count; j++)
                {
                    for (int k = 0; k != Tiles[j].Count; k++)
                    {
                        if (k.ToString() == nv.ToString())
                        {
                            subsubtile.Add(nv);
                        }
                        else if (k.ToString() == f.ToString())
                        {

                            subsubtile.Add(Resource);


                        }
                    }
                    subtile.Add(subsubtile);
                }
                ft.Add(subtile);
            }

            FinalTile = ft;
        }



        public override void outputTile(int rotation)
        {
            throw new NotImplementedException();
        }



    }

    
}
