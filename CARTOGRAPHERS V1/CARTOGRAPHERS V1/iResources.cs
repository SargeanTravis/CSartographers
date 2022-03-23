using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1
{
    interface iResources
    {



        //Coordinate system: used to attempt to place a tile.
        public void setX(int _x);

        public void setY(int _y);

        public int[] getCoord();

        public void setCoords(int _x, int _y);


    }
}
