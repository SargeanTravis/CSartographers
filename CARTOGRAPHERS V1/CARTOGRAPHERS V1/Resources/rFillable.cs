using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1.Resources
{
    class rFillable : iResources//Placeholder value for placeTile()
    {

        private string placeholder = "XX";
        public readonly string placeholderRuins = "RX";

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

        public string Placeholder
        {
            get
            {
                return placeholder;
            }
        }

        public override string ToString()
        {
            return Placeholder;
        }

        


    }
}
