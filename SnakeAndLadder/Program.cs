﻿using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0; //local variable
            int player = 1;
              // creating an object
            Random random = new Random();
            // calling the Next() Method for generating random values
            int dieInput = random.Next(1, 7);
            Console.WriteLine("Snake and Laddergame played by a player" + " " + player + " " + "at start position" + " " + position);
        }
        
    }
}
