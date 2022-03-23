using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.pTerrainTiles
{
    class Filled : pTerrain
    {

        private String tile;

        public String Tile
        {
            get
            {
                return tile;
            }
            set
            {
                tile = value;
            }
        }

        public override string ToString()
        {
            return Tile;
        }

        public Filled(String value)
        {
            Tile = value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Filled))
            {
                return false;
            }
            return (this.tile == ((Filled)obj).Tile);



        }



    }
}
