# CSartographers
A Console Based emulation of the board game Cartographers. WIP

#What the game is
Cartographers is a 1-4 player tile placement game (like tetris, but on a piece of paper) where users place various sets of tiles on the board and score points based on how they are arranged as well as randomly selected scoring conditions, played over 4 rounds, called seasons. After the final season, the winner is the player with the most points.

This is my attempt at creating a Console Application emulator for this pencil-and-paper board game. A lot of the components are ready as-is, but there's still a lot to work on it. 

#Things I have achieved:
-Several hierarchies of objects that are used to create in-game tiles
-A Map Object that creates the playing surface
-The methods required in theory to place tiles on the board.
-Some fo the in-game tiles that can be selected in-game.
-Some test methods 

#Things left to complete:
-Tile Placement is hella buggy.
-Cards  and score system need to be implemented.
-A working executable that packages up all of these issues

#My Top Priority Right Now
-Creating a virtual placement system. What I mean is, it takes a selected tile, sets it to the given offests from the starting corner of 0,0 (the top left corner), and displays the potential position of the tile relative to the map, bvefore any final changes are pushed to the map.
