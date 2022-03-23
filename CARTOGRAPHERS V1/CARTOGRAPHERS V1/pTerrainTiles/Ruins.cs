using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.pTerrainTiles
{
    class Ruins: pTerrain
    {
        private string ruinTile;

        public string RuinTile
        {
            get
            {
                return ruinTile;
            }
            set
            {
                ruinTile = value;
            }
        }

        public Ruins()
        {
            RuinTile = "-R";
        }

        public Ruins(string tile)
        {
            RuinTile += tile;
        }

        public override string ToString()
        {
            return RuinTile;
        }

        public override bool Equals(object obj)//This is used to check empty ruins tiles
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Ruins))
            {
                return false;
            }
            return ("-R" == ((Ruins)obj).RuinTile);



        }


    }
}
