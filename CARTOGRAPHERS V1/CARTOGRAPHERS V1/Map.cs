using CARTOGRAPHERS_V1.pTerrainTiles;
using CARTOGRAPHERS_V1.Resources;
using CARTOGRAPHERS_V1.TileMechanics;
using System;
using System.Collections.Generic;
using System.Text;


namespace CARTOGRAPHERS_V1
{
    class Map
    {



        private String[,] mapArray;//Map is not a List as the game is fixed to a 11X11 grid
        private iResources[,] scoreArray;//Copy of map that is not visual but only holds iResource values that track scoring properties.

        private int xOffset;//Sets the X-axis offset of the tile to be placed from 0,0, the top left corner fo the board
        private int yOffset;//Sets the Y-axis offset of the tile to be placed from 0,0 the top left corenr of the board.

        //TODO: Move tile creation to this class and create global tile objects
        public DRTile[] drTileObjects;
        public dtTile[] dtTileObjects;
        public mTile[] mTileObjects;



        //Begin Constructors

        public String[,] MapArray
        {
            get
            {
                return mapArray;
            }
            set
            {
                mapArray = value;
            }
        }

        public iResources[,] ScoreArray
        {
            get
            {
                return scoreArray;
            }
            set
            {
                scoreArray = value;
            }
        }

        public int XOffset
        {
            get
            {
                return xOffset;
            }
            set
            {
                xOffset = value;
            }
        }

        public int YOffset
        {
            get
            {
                return yOffset;
            }
            set
            {
                yOffset = value;
            }
        }

        //There is two map configurations in Cartographers: A map with a full 11X11 board with mountains, and a wastelands version with mountains and wasteland tiles (effectively mountains)
        //This is controlledvia a passed in boolean value that is by default false, therefore indicating the former map selection. 

        //TODO: Move tile creation to this class and create global tile objects
        public Map(bool isWastelands = false)
        {
            
            rMountain rm1 = new rMountain();
            
            rMountain rm2 = new rMountain();
            
            rMountain rm3 = new rMountain();
            
            rMountain rm4 = new rMountain();
            
            rMountain rm5 = new rMountain();
            Ruins ntr = new Ruins();
            Empty e = new Empty();
            Wasteland w = new Wasteland();
            

            if (isWastelands == false)
            {
                String[,] dma =
                {
                   {"--","--","--","--","--","--","--","--","--","--","--"},
                   {"--","--","--",rm1.ToString(),"--","-R","--","--","--","--","--",},
                   {"--","-R","--","--","--","--","--","--",rm2.ToString(),"-R","--"},
                   {"--","--","--","--","--","--","--","--","--","--","--"},
                   {"--","--","--","--","--","--","--","--","--","--","--",},
                   {"--","--","--","--","--",rm3.ToString(),"--","--","--","--","--",},
                   {"--","--","--","--","--","--","--","--","--","--","--",},
                   {"--","--","--","--","--","--","--","--","--","--","--",},
                   {"--","-R",rm4.ToString(),"--","--","--","--","--","--","-R","--"},
                   {"--","--","--","--","--","-R","--",rm5.ToString(),"--","--","--"},
                   {"--","--","--","--","--","--","--","--","--","--","--"}
                };

                rm1.setCoords(3, 1);
                rm2.setCoords(8, 2);
                rm3.setCoords(5, 5);
                rm4.setCoords(2, 8);
                rm5.setCoords(7, 9);

                iResources[,] scorePlain =
                {
                    {new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),
                        new rFillable(),new rFillable(),new rFillable() },
                    {new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),
                        new rFillable(),new rFillable(),new rFillable() },
                    {new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),
                        new rFillable(),new rFillable(),new rFillable() },
                    {new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),
                        new rFillable(),new rFillable(),new rFillable() },
                    {new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),
                        new rFillable(),new rFillable(),new rFillable() },
                    {new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),
                        new rFillable(),new rFillable(),new rFillable() },
                    {new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),
                        new rFillable(),new rFillable(),new rFillable() },
                    {new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),
                        new rFillable(),new rFillable(),new rFillable() },
                    {new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),
                        new rFillable(),new rFillable(),new rFillable() },
                    {new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),
                        new rFillable(),new rFillable(),new rFillable() },
                    {new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),new rFillable(),
                        new rFillable(),new rFillable(),new rFillable() }



                };

                ScoreArray = scorePlain;

                ScoreArray[1, 3] = rm1;
                ScoreArray[2, 8] = rm2;
                ScoreArray[5, 5] = rm3;
                ScoreArray[8, 2] = rm4;
                ScoreArray[9, 7] = rm5;


                MapArray = dma;



            }
            else
            {
                String[,] dwma =
                {
                    {"--","--","--","--","--","--","--","--","--","--","--"},
                    {"--","--","--","--","--","--","-R","--",rm1.ToString(),"--","--"},
                    {"--","--","-R",rm2.ToString(),"--","--","--","--","--","--","--"},
                    {"--","--","--","--","--",w.ToString(),"--","--","--","--","--"},
                    {"--","--","--","--",w.ToString(), w.ToString(),"-R","--","--","--","--"},
                    {"--","--","--","--",w.ToString(), w.ToString(), w.ToString(),"--","--","--","--"},
                    {"--","-R","--","--","--",w.ToString(),"--","--","--","--","--"},
                    {"--","--","--","--","--",rm3.ToString(),"--","--","-R", "--","--"},
                    {"--","--","--","--","--","--","--","--","--",rm4.ToString(),"--"},
                    {"--","--",rm5.ToString(),"-R","--","--","--","--","--","--","--"},
                    {"--","--","--","--","--","--","--","--","--","--","--"}
                };

                rm1.setCoords(8, 1);
                rm2.setCoords(3, 2);
                rm3.setCoords(5, 7);
                rm4.setCoords(9, 8);
                rm5.setCoords(2, 9);

                ScoreArray[1, 8] = rm1;
                ScoreArray[2, 3] = rm2;
                ScoreArray[7, 5] = rm3;
                ScoreArray[8, 9] = rm4;
                ScoreArray[9, 2] = rm5;

                //Setting coordinates for ScoreArray Wastelands as they are considered border spaces in scoring situations
                ScoreArray[3, 5] = new rWasteland(5, 3);
                ScoreArray[4, 4] = new rWasteland(4, 4);
                ScoreArray[4, 5] = new rWasteland(5, 4);
                ScoreArray[5, 4] = new rWasteland(4, 5);
                ScoreArray[5, 5] = new rWasteland(5, 5);
                ScoreArray[5, 6] = new rWasteland(6, 5);
                ScoreArray[6, 6] = new rWasteland(6, 6);




                MapArray = dwma;
            }
        }

        //End Constructors


        //Display map to console
        public void displayMap()
        {
            MapBorder mb = new MapBorder();

            Console.WriteLine(mb.ToString());

            for (int i = 0; i != 11; i++)
            {

                for (int j = 0; j != 11; j++)
                {
                    Console.Write("| {0} ", MapArray[i, j]);
                }

                Console.WriteLine("|");
                Console.WriteLine(mb.ToString());
            }

        }
        //Overload for simulatePlacement()
        public void displayMap(pTerrain[,] map)
        {
            MapBorder mb = new MapBorder();

            Console.WriteLine(mb.ToString());

            for (int i = 0; i != 11; i++)
            {

                for (int j = 0; j != 11; j++)
                {
                    Console.Write("| {0} ", map[i, j]);
                }

                Console.WriteLine("|");
                Console.WriteLine(mb.ToString());
            }

        }
        //Begin User Interface system for placeTile(). Prints all valid commands 
        public String UIController(DRTile tile, bool selectedTileType, bool tileIsValid, bool shouldBeOnRuins, bool canW, bool canA, bool canS, bool canD)
        {
            string input = "";

            List<String> commands = new List<String>();


            return input;
        }

        //How the program adds tiles to player maps
        public void placeTile(int tile_id, bool isRuins)
        {

            String[,] tempMap = mapArray;

            String input = "S";//User input string (sine Action Listeners are too ahrd to implement

            int[] drTiles = { };//Marks double resource tiles
            int[] dtTiles = { };//Marks double tileset tiles
            int[] mTiles = { };//Marks Monster Tiles
            int wildTile = 0; //Marks Wild Tile instance;  TODO: Replace this


            //Lots of boolean functions in this one, oh boy

            bool placedTile = false;//This loop will run while the placement has not been confirmed
            bool selectedTileType = false;//User wants the selected tile, regardless if it's drTile or dtTile
            bool tileIsValid = true;//This boolean prevents illegal placements on un-overlappable tiles

            bool isWild = false;//This boolean condition determines if a wild tile is needed after validation or by drawing a wild tile
            bool isResource = false;//Is this a Double Resource Tile?
            bool isDouble = false; //Is this a Double Tileset Tile?
            bool isMonster = false; //Is this a Monster Tile?

            bool shouldBeOnRuins = false; //Should this tile be limited to Ruin tile placements?

            bool canW = false;//Can you move the tile 1 space up? Default false due to corner position
            bool canA = false;//Can you move 1 tile left? Default false due to corner position
            bool canS = true;//Can you move 1 tile down? Default true due to cornere position
            bool canD = true;//Can you move 1 tile right? Default true due to corner position

            /*
             Pseudocode:
            1.Determine tile drawn from ID
            2.If it's a DOuble resource Tile or Monster Tile, validate Once
            3.Otherwise Validate twice
            4.Give user option to swap tile resource value and/or tileset, and position
                -Resource value: Keep coordinates, swap resource values
                -Tile Value Reset coords but swap tile
                -position: check for borders, give user valid UI prompts
                -Redisplay map every time a change is made
            5.Write changes to map once user finalizes decision, return this map.
             */

            //1.Determine tile drawn from ID
            foreach (DRTile tile in drTileObjects)//Resource TIle
            {
                if (tile.Tile_ID == tile_id)
                {
                    isResource = true;
                    break;
                }




            }
            if (!isResource)//Double Tiles Tile
            {

                foreach (dtTile tile in dtTileObjects)
                {
                    if (tile.Tile_ID == tile_id)
                    {
                        isDouble = true;
                        break;
                    }
                }
            }
            if (!isResource && !isDouble)//Monster Tile
            {
                foreach (mTile tile in mTileObjects)
                {
                    if (tile.Tile_ID == tile_id)
                    {
                        isMonster = true;
                        break;
                    }
                }
            }
            else//Is none of the previous and is a drawn Wild Tile
            {
                isWild = true;
            }



            //2.If it's a DOuble resource Tile or Monster Tile (and not a wild), validate Once
/*
            if ((isResource || isMonster) && !isWild)
            {
                if (isResource) //Double Resource Tile
                {

                    foreach (DRTile tile in drTileObjects)
                    {


                        if (tile.Tile_ID == tile_id) {//If Tile ID is found, validate and escape method

                            isWild = isFullTileValid(tile.Tiles);
                            break;

                        }

                    }


                }
                else //Monster Tile
                {

                    foreach (mTile tile in mTileObjects)
                    {

                        if (tile.Tile_ID == tile_id)
                        {//If Tile ID is found, validate and escape method

                            isWild = isFullTileValid(tile.Tiles);
                            break;

                        }
                    }



                }



            }//3.Otherwise Validate twice (If not Wild)
            else//Double Tiles Tile
            {
                if (!isWild)
                {

                    foreach (dtTile tile in dtTileObjects)
                    {
                        if (tile.Tile_ID == tile_id)
                        {
                            //If Tile ID is found, validate and escape method

                            isWild = isFullTileValid(tile.Tiles);

                            if (isWild) //If isWild suddently is true now, test for the second tileset
                            {

                                isWild = isFullTileValid(tile.Tiles2);




                            }
                            break;

                        }


                    }



                }



            }
            /*
             * 4.Give user option to swap tile resource value and/or tileset, and position
                -Resource value: Keep coordinates, swap resource values
                -Tile Value Reset coords but swap tile
                -position: check for borders, give user valid UI prompts
                -Redisplay map every time a change is made
            
             */





            do
            {

                //retrieve the desired Tile object
                if (isResource)
                {
                    DRTile toBePlaced = null;

                    switch (input)
                    {
                        case "S"://Swap Shape
                        case "s":
                            foreach (DRTile tile in drTileObjects)//Retrieve tile object
                            {

                                if (tile.Tile_ID == tile_id)
                                {
                                    toBePlaced = tile.copyTo(toBePlaced);
                                }




                            }
                            //Set coordinates
                            break;
                    }

                }







            } while (!placedTile);










        }


/*

        //Only takes in the tileset and not the whole object because the whole object is problematic and generally too much information this method needs
        public bool isFullTileValid(List<List<List<iResources>>> tile)//Uses a slimmed down version of placeTile until an open spot is available, otherwise returns false and switches to Wild Tile
        {
            //counter variables for the map coords and tile rotation
            int x = 0;
            int y = 0;
            int rotation = 0;


            //If any part of the tile overlaps with existing terrain, this temporary becomes false and the tile is shifted oone place right then one place down respectively
            bool tileIsValid = true;

            //Will hold the tile to test 
            List<List<iResources>> testTile;


            for (; rotation != tile.Count - 1; ++rotation)//Run for each tile rotation
            {
                testTile = tile[rotation];

                //Second for loop controls Y coordinates

                for (; y < mapArray.Length - 1; ++y)
                {

                    //Third for loop controls X coordinates; mapArray is always 11X11 so this is valid
                    for (; x < mapArray.Length; ++x)
                    {

                        //FOURTH for loop controls Y cordinates of testTile



                        for (int y2 = 0; y2 < testTile.Count; y2++)
                        {
                            //Break out of loop if tile already overlaps
                            if (!tileIsValid)
                            {
                                break;
                            }


                            //Final for loop controls x coord for testTile and verfies if the tile is valid
                            for (int x2 = 0; x2 < testTile[y2].Count; x2++)
                            {
                                if (x + testTile[y2].Count > 10)//Cancel placement if original tile setup would be out of bounds
                                {
                                    break;
                                }


                                iResources resource = testTile[y2][x2];//Obtain resource value of testTile at the coordinates of this tile

                                pTerrain terrain = mapArray[y + y2, x + x2];//Obtain resource value of where testTile's current tile would go, which is the current mapArray coordinate plus the tile coordinate modifier


                                //If the tile appears to be invalid on the map side
                                if (terrain.Equals(new Mountain()) || terrain.Equals(new Wasteland()) || !(terrain.Equals(new Empty())))
                                {
                                    //If the tile could go where the map says is invalid and the testTile tile is null, break out and shift the tile.
                                    if ((resource.ToString()).Equals("XX"))
                                    {
                                        tileIsValid = false;
                                        break;
                                    }


                                }



                            }


                        }

                        //If tile Overlap hasn't occured escape the method, else reset the tile
                        if (tileIsValid)
                        {
                            return false;
                        }
                        else
                        {
                            tileIsValid = true;
                        }


                    }



                }



            }


            //Return True if no valid positions are found
            return true;
        }

        //Begin special print commands for a new Tile. It returns a bool value to prevent finalization of an invalid placement.
        public bool simulatePlacement(DRTile tile, int rotation, bool isRuins)
        {
            pTerrain[,] mapArrayCopy = mapArray;//Prevents unauthorized changes
            
            //This tile will be displayed on the copy if an overlap occurs.
            Filled errorFill = new Filled("!!");
            


            //Default validation booleans
            //bool check = false;
            bool returnValue = true;
            bool RuinsConditionFulfilled = false;

            //filling the Final Tile as a part of the simulation
            tile.FillTile();


            List<List<iResources>> prototile = tile.FinalTile[rotation];//Retrieve desired tileset and rotation pattern

            



            //Set coordinates
            for(int i = 0; i < prototile.Count; i++)
            {
                for(int j = 0; j < prototile[i].Count; i++)
                {
                    iResources resource = prototile[i + YOffset][j + XOffset];
                    resource.setCoords(i, j);
                    prototile[i][j] = resource;//Setting coordinates that will be read soon; All resources have these commands by default so this should work


                    Console.WriteLine(prototile[i][j].ToString());
                }
            }


            //First for loop controls Y coordinates inside prototile
            for(int i =0; i < prototile.Count; i++)
            {
                //Second for loop controlls prototile X Coordinates
                
                for(int j =0; j < prototile[i].Count; j++)
                {
                    pTerrain terrain = mapArrayCopy[i + YOffset , j + XOffset];

                    

                    if(!terrain.Equals(new Empty()))//If the tile at this coordinate isnt empty see what it is
                    {
                        if(terrain.Equals(new Ruins()))//If the tile is empty, then it is compatible regardless
                        {

                            if (isRuins)//If this action satisfies the IsRuins condition, this placement is legal provided no other tiles illegally overlap.
                            {
                                RuinsConditionFulfilled = true;
                            }
                            
                            mapArrayCopy[i + YOffset, j + XOffset] = new Filled("R" + (prototile[i][j].ToString()[prototile[i][j].ToString().Length - 1]));
                        }
                        else//Mountains/ Already placed tiles are illegal, so therefore this cannot be valid.
                        {
                            mapArrayCopy[i + YOffset, j + XOffset] = errorFill;
                            returnValue = false;
                        }
                        



                    }
                    else//If the tile is Empty, virtually place the tile on the copy grid
                    {
                        mapArrayCopy[i + YOffset, j + XOffset] = new Filled(prototile[i][j].ToString());
                    }
                    



                }



            }

            if(isRuins && !RuinsConditionFulfilled)//Fail if tile on ruins condition is not met
            {
                returnValue = false;
            }
            


            displayMap(mapArrayCopy);//Use overloaded displayMap() for this method

            return returnValue;
        }


*/

        //Moving this class into Map as this map be root problem of why Class iResource Tiels aren't generating and therefore causing trouble    
        //This overload handles double resources
        public  List<List<List<iResources>>> FillTile(DRTile tile)
        {
            List<List<List<iResources>>> tempTile = tile.Tiles;

            List<List<List<iResources>>> ft = new List<List<List<iResources>>>();

            //My somewhat unique way of filling the final tile: creating each list individually and then nesting them when required.
            
           



            rNull nv= new rNull();
            rFillable f = new rFillable();

            for(int i =0;i!=tempTile.Count;i++)
            {
                List<List<iResources>> subtile = new List<List<iResources>>();

                for (int j =0; j!=tempTile[i].Count;j++)
                {
                    List<iResources> subsubtile = new List<iResources>();

                    for (int k =0; k!=tempTile[j].Count;k++)
                    {
                        if(k.ToString()==nv.ToString())//Do nothing if there should be nothing there.
                        {
                            

                            subsubtile.Add(new rNull());
                        }
                        else if (k.ToString() == f.ToString())//Do something if something should be there
                        {
                            if(tile.Selected_Tile == false)//Resource 1
                            {
                                
                                
                                subsubtile.Add(tile.Resource_One);//Nest this value
                                

                            }
                            else//Resource 2
                            {
                                subsubtile.Add(tile.Resource_Two);//Nest this value
                            }



                        }
                    }
                    subtile.Add(subsubtile);//Nest this row
                }
                ft.Add(subtile);//Nest this tile rotation
            }

            return ft;
        }
        
        //Moving this class into Map as this map be root problem of why Class iResource Tiels aren't generating and therefore causing trouble    
        //This overload handles double tilesets
        public  List<List<List<iResources>>> FillTile(dtTile tile)
        {
            List<List<List<iResources>>> tempTile = tile.SelectTileset();



            List<List<List<iResources>>> ft = new List<List<List<iResources>>>();

            List<List<iResources>> subtile = new List<List<iResources>>();
            List<iResources> subsubtile = new List<iResources>();



            rNull nv = new rNull();
            rFillable f = new rFillable();

            for (int i = 0; i != tempTile.Count; i++)
            {
                for (int j = 0; j != tempTile[i].Count; j++)
                {
                    for (int k = 0; k != tempTile[j].Count; k++)
                    {
                        if (k.ToString() == nv.ToString())
                        {
                            subsubtile.Add(nv);
                        }
                        else if (k.ToString() == f.ToString())
                        {

                            subsubtile.Add(tile.Resource);


                        }
                    }
                    subtile.Add(subsubtile);
                }
                ft.Add(subtile);
            }

            return ft;

        }


        //Moving this class into Map as this map be root problem of why Class iResource Tiles aren't generating and therefore causing trouble    
        //This overload handles wilds

        public List<List<List<iResources>>> FillTile(wTile tile)
        {
            List<List<List<iResources>>> ft = new List<List<List<iResources>>>();

            List<List<iResources>> subtile = new List<List<iResources>>();
            List<iResources> subsubtile = new List<iResources>();



            rNull nv = new rNull();
            rFillable f = new rFillable();

            ft[0][0][0] = tile.Resource;

            return ft;
        }

        //Moving this class into Map as this map be root problem of why Class iResource Tiels aren't generating and therefore causing trouble    
        //This overload handles wilds

        public List<List<List<iResources>>> FillTile(mTile tile)
        {
            List<List<List<iResources>>> tempTile = tile.Tiles;

            List<List<List<iResources>>> ft = new List<List<List<iResources>>>();

            
            List<List<iResources>> subtile = new List<List<iResources>>();
            List<iResources> subsubtile = new List<iResources>();



            rNull nv = new rNull();
            rFillable f = new rFillable();

            for (int i = 0; i != tempTile.Count; i++)
            {
                for (int j = 0; j != tempTile[i].Count; j++)
                {
                    for (int k = 0; k != tempTile[j].Count; k++)
                    {
                        if (k.ToString() == nv.ToString())//Do nothing if there should be nothing there.
                        {
                            subsubtile.Add(nv);
                        }
                        else if (k.ToString() == f.ToString())//Do something if something should be there
                        {

                            subsubtile.Add(new rMonster());


                        }
                    }
                    subtile.Add(subsubtile);//Nest this row
                }
                ft.Add(subtile);//Nest this tile rotation
            }

            return ft;
        }


    }
}
