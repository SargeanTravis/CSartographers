﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CARTOGRAPHERS_V1
{
    abstract class Tile
    {

        //This holds every rotation of the tile stored in a child Tile object.
        private List<List<List<iResources>>> tiles;
        //Generic Tile ID used in a randomization system that will be implemented separately
        private int tile_id;
        //Defines the name for the tile
        public string Name;
        //Context: Game runs on 4 rounds (seasons), and each round has X time. when a new tile is drawn,
        //subtract this value from time remaining in round.
        public int Time;


        //Begin Constructors

        public List<List<List<iResources>>> Tiles
        {
            get
            {
                return tiles;
            }
            set
            {
                tiles = value;
            }
        }

        public int Tile_ID
        {
            get
            {
                return tile_id;
            }
            set
            {
                tile_id = value;
            }
        }

        

        public Tile(List<List<List<iResources>>> ts, int id, string name, int tc)
        {
            Tiles = ts;
            Tile_ID = id;
            Name = name;
            Time = tc;
        }

        //This allows placeTile to run validation check twice if need be
        public virtual bool IsDoubleTiles()
        {
            return false;
        }

        //End COnstructors

        //Used to replace Fillable (XX) Tiles in the tile with the iResource type chosen by the user
        public abstract List<List<List<iResources>>> FillTile();

        //Acts as ToString but flexible to rotation and 
        public abstract void outputTile(int rotation);
    
    }
}