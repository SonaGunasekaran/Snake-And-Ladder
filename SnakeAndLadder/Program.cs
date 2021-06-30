﻿using System;

namespace SnakeAndLadder
{
    class Program
    { 
        public const int LADDER_POS = 2;
        public const int SNAKE_POS = 1;
        public const int NO_PLAY = 0;
        public const int USER_DES = 100;

        public static void Main(string[] args)
        {
            //local variable
            int position = 0; 
            int player = 1;
            int userpos = 0;
            int i=0;
            //creating an object
            Random random = new Random();
            
            while(i==0 || i <= USER_DES)
            {
                // calling the Next() Method for generating random values
                int dieInput = random.Next(1, 7);
                int choice = random.Next(1, 3);
                // Selection statement
                switch (choice)
                {
                    case LADDER_POS:
                        position += dieInput;
                        break;
                    case SNAKE_POS:
                        position -= dieInput;
                        break;
                    case NO_PLAY:
                        position += 0;
                        break;
                }
                if(position>USER_DES)
                {
                    userpos +=position ;
                }
                else if(position==USER_DES)
                {
                    break;
                }
                else
                {
                    i++;
                }


            }
            Console.WriteLine("The player" + " " + player + " " + "won the game by reaching" + " " + position);

        }
        
    }
   

 }
        
