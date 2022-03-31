using CARTOGRAPHERS_V1.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.TileMechanics
{
    class dtTile : Tile//Double Tileset Tile
    {
        
        //This is the second set of possible tiles this could be based on user selection
        private iResources[,,] tiles2;

        
        //The sole resource this tile can be
        private iResources resource;

        //There is two booleans for this Tile object; Because in the game, one of the two tilesets determines which has a coin attached to it;
        //When the user selects this coin tile, they get a point towards their score. Therefore, A boolean is used to track which set. true indicates the first 
        //tileset has coin (the tiles tileset in the Tiles class)
        //Selector is for selecting which of the Two tilesets to use as the placed tileset, much like drTile ujses this boolean to select a resource type.
        //This one is important as I need validation to run twice for this tile type.
        //False = tiles, True = tiles2
        private bool cointile;
        private bool selector;

        //Begin Constructors

        public iResources[,,] Tiles2
        {
            get
            {
                return tiles2;
            }
            set
            {
                tiles2 = value;
            }
        }

        public bool CoinTile
        {
            get
            {
                return cointile;
            }
            set
            {
                cointile = value;
            }
        }

        public bool Selector
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

        public iResources Resource
        {
            get
            {
                return resource;
            }
            set
            {
                resource = value;
            }
        }

        

        public dtTile(iResources[,,] ts, iResources[,,] ts2, int tc, int id, string name, bool coin, bool select, iResources r) : base(ts, id, name, tc)
        {
            Tiles2 = ts2;
            CoinTile = coin;
            Selector = select;
            Resource = r;

            
        }

        //Copy constructor; My solution to trying to sort a list of tiles
        public dtTile copyTo(dtTile tile)
        {
            dtTile newTile= new dtTile(tile.Tiles, tile.Tiles2, tile.Time, tile.Tile_ID,tile.Name, tile.CoinTile, tile.Selector, tile.Resource);


            return newTile;
        }

        //End Constructors

        //This allows placeTile to run validation check twice if need be
        public override bool IsDoubleTiles()
        {
            return true;
        }


        //Outputs the first or second tileset based on selector
        public iResources[,,] SelectTileset()
        {
            iResources[,,] protofinalset = Tiles2;

            if(selector==false)
            {
                protofinalset = Tiles;
            }
            




            return protofinalset;
        }
        
        //Fills template with correct values
        //See drTile for reference on how this works
        

        

    }

   

}
