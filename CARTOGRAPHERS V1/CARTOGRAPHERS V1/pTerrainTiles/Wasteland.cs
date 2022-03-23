using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.pTerrainTiles
{
    class Wasteland: pTerrain
    {
        private string wastelandTile = "WW";

        public string WastelandTile
        {
            get
            {
                return wastelandTile;
            }
        }

        public override string ToString()
        {
            return WastelandTile;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Wasteland))
            {
                return false;
            }
            return (this.wastelandTile == ((Wasteland)obj).WastelandTile);



        }
    }
}
