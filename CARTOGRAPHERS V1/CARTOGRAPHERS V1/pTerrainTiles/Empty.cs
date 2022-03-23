using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.pTerrainTiles
{
    class Empty: pTerrain
    {

        private string noTerrain = "  ";

        public string NoTerrain
        {
            get
            {
                return noTerrain;
            }
        }

        public override string ToString()
        {
            return NoTerrain;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if (!(obj is Empty))
            {
                return false;
            }
            return (this.noTerrain == ((Empty)obj).NoTerrain);



        }

    }
}
