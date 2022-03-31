using CARTOGRAPHERS_V1.Resources;
using System;
using System.Collections.Generic;

namespace CARTOGRAPHERS_V1.TileMechanics
{
    class wTile : Tile//Wild Tile (For Rift Lands/Invalid piece placement)
    {

        
        private int selector;//integer selector instead of boolean due to below comment V

        public readonly iResources[] SELECTOR_ARRAY = { };//WIld Tile can be any legal placable tile in the gaqme, therefore it controls its own tile selection
        public iResources Resource;

        //Begin Constructors


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

        public wTile(iResources[,,] ts, int id, string name, int tc, iResources r): base(ts, id, name, tc)
        {

            Resource = r;

            Selector = SwitchResource();


        }

        //End Constructors

        public int SwitchResource()
        {

            //TODO: Implement WIldTile's functionality

            return 0;
        }



    }

    
}
