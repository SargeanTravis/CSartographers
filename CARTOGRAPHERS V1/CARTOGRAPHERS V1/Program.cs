using CARTOGRAPHERS_V1.Resources;
using CARTOGRAPHERS_V1.TileMechanics;
using System;
using System.Collections.Generic;

namespace CARTOGRAPHERS_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            //This initializes the Tile Cards utilized for the game
            #region "Template construction"

            
            rForest f = new rForest();
            rHouse h = new rHouse();
            rRiver r = new rRiver();
            rForest t = new rForest();
            rField w = new rField();

            List<iResources> subsubtile = new List<iResources>();
            List<List<iResources>> subtile = new List<List<iResources>>();
            List<List<List<iResources>>> tile = new List<List<List<iResources>>>();
            #region "Tile 1"
            subsubtile.Add(new rFillable());//####
            subsubtile.Add(new rFillable());
            subsubtile.Add(new rFillable());
            subsubtile.Add(new rFillable());
            subtile.Add(subsubtile);
            tile.Add(subtile);
            subsubtile.Clear();
            subtile.Clear();

            subsubtile.Add(new rFillable());//#
            subtile.Add(subsubtile);
            subsubtile.Clear();
            subsubtile.Add(new rFillable());//#
            subtile.Add(subsubtile);
            subsubtile.Clear();
            subsubtile.Add(new rFillable());//#
            subtile.Add(subsubtile);
            subsubtile.Clear();
            subsubtile.Add(new rFillable());//#
            subtile.Add(subsubtile);
            tile.Add(subtile);
            subsubtile.Clear();
            subtile.Clear();


            DRTile a = new DRTile(tile, 1, "Fishing Village", 2, h, r, false);

            tile.Clear();
            #endregion
            #region "Tile 2"

            subsubtile.Add(new rNull());//-###
            subsubtile.Add(new rFillable());
            subsubtile.Add(new rFillable());
            subsubtile.Add(new rFillable());
            subtile.Add(subsubtile);
            subsubtile.Clear();
            subsubtile.Add(new rFillable());//##--
            subsubtile.Add(new rFillable());
            subsubtile.Add(new rNull());
            subsubtile.Add(new rNull());
            subtile.Add(subsubtile);
            tile.Add(subtile);
            subsubtile.Clear();
            subtile.Clear();

            subsubtile.Add(new rFillable());//#-
            subsubtile.Add(new rNull());
            subtile.Add(subsubtile);
            subsubtile.Clear();
            subsubtile.Add(new rFillable());//#-
            subsubtile.Add(new rNull());
            subtile.Add(subsubtile);
            subsubtile.Clear();
            subsubtile.Add(new rFillable());//##
            subsubtile.Add(new rFillable());
            subtile.Add(subsubtile);
            subsubtile.Clear();
            subsubtile.Add(new rNull());//-#
            subsubtile.Add(new rFillable());
            subtile.Add(subsubtile);
            tile.Add(subtile);
            subsubtile.Clear();
            subtile.Clear();

            subsubtile.Add(new rNull());//-###
            subsubtile.Add(new rFillable());
            subsubtile.Add(new rFillable());
            subsubtile.Add(new rFillable());
            subtile.Add(subsubtile);
            subsubtile.Clear();
            subsubtile.Add(new rFillable());//##--
            subsubtile.Add(new rFillable());
            subsubtile.Add(new rNull());
            subsubtile.Add(new rNull());
            subtile.Add(subsubtile);
            tile.Add(subtile);
            subsubtile.Clear();
            subtile.Clear();

            subsubtile.Add(new rFillable());//#-
            subsubtile.Add(new rNull());
            subtile.Add(subsubtile);
            subsubtile.Clear();
            subsubtile.Add(new rFillable());//##
            subsubtile.Add(new rFillable());
            subtile.Add(subsubtile);
            subsubtile.Clear();
            subsubtile.Add(new rNull());//-#
            subsubtile.Add(new rFillable());
            subtile.Add(subsubtile);
            subsubtile.Clear();
            subsubtile.Add(new rNull());//-#
            subsubtile.Add(new rFillable());
            subtile.Add(subsubtile);
            tile.Add(subtile);
            subsubtile.Clear();
            subtile.Clear();

            DRTile b = new DRTile(tile, 2, "Treetop Village", 2, f, h, false);

            #endregion

            #endregion


            

            Map test = new Map();



            test.displayMap();

            test.XOffset = 0;
            test.YOffset = 1;

            List<List<List<iResources>>> testing = test.FillTile(a);

            foreach(List<List<iResources>>tileRotation in a.Tiles)
            {

                foreach(List<iResources> tileRow in tileRotation)
                {
                    foreach(iResources resource in tileRow)
                    {
                        Console.Write(resource.ToString()+" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
            }

            

           // bool check = test.simulatePlacement(b, 0, false);





            //Console.WriteLine(check);


        }
    }
}
