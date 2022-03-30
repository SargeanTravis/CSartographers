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
            Selected_Tile = selector;
            Resource_One = r1;
            Resource_Two = r2;

            
        }

        public DRTile copyTo(DRTile tile)
        {
            DRTile newTile = new DRTile(tile.Tiles, tile.Tile_ID, tile.Name, tile.Time, tile.Resource_One, tile.Resource_Two, tile.Selected_Tile);


            return newTile;
        }

        //End Constructors

        

        



        


        

    }
}
