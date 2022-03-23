using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.pTerrainTiles
{
    class Mountain: pTerrain
    {
        private string mountainTile = "MM";

        public string MountainTile
        {
            get
            {
                return mountainTile;
            }
        }

        public override string ToString()
        {
            return MountainTile;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Mountain))
            {
                return false;
            }
            return (this.mountainTile == ((Mountain)obj).MountainTile);



        }

    }
}
