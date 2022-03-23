using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.Resources
{
    class rWasteland: iResources//Same as mountain; This is only used in the ScoreArray for scoring purposes.
    {

        
        public readonly string Wasteland = "WL";

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

        public rWasteland(int x, int y)
        {
            setCoords(x, y);
        }

        public override string ToString()
        {
            return Wasteland;
        }
    }
}
