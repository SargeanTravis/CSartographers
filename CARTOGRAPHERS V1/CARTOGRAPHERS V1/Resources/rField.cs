using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.Resources
{
    class rField : pTerrain//Represents a Field Tile
    {

        public readonly string Field = "WW";
        public readonly string RuinField = "RW";
        
        
        private int x;
        private int y;


        //Coordinate system: used to attempt to place a tile.
        public void setX(int _x)
        {
            x = _x;
        }

        public void setY(int _y)
        {
            y = _y;
        }

        public int[] getCoord()
        {
            int[] coords = new int[2];

            coords[0] = x;
            coords[1] = y;


            return coords;
        }

        public void setCoords(int _x, int _y)
        {
            setX(_x);
            setY(_y);
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
    
}
