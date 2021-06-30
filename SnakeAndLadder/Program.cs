using System;

namespace SnakeAndLadder
{

    using System;

    namespace SnakeAndLadder
    {
        class Program
        {
            public const int LADDER_POS = 2;
            public const int SNAKE_POS = 1;
            public const int NO_PLAY = 0;
            public const int USER_DES = 100;
            public const int PLAYER_1 = 0;
            public const int PLAYER_2 = 1;


            public static void Main(string[] args)
            {
                Random random = new Random();
                int n = 0;
                for(n=0;n<2;n++)
                {
                    int[] player = new int[2];
                    player[0] = Program.playerOne();
                    player[1] = Program.playerTwo();
                    
                }
                int countOne = Program.myPlayers();
                int countTwo = Program.myPlayers();
                if (countOne < countTwo)
                {
                    Console.WriteLine("Player One is the winner");
                }
                else
                {
                    Console.WriteLine("Player Two is the winner");
                }
            }
            public static int playerOne()
            {
                int countOne;
                countOne = myPlayers();
                return countOne;

            }
            public static int playerTwo()
            {
                int countTwo;
                countTwo = myPlayers();
                return countTwo;

            }

            public static int myPlayers()
            {
                int position = 0; //local variable
               
                int count = 0;
                int i = 0;

                Random random = new Random();

                while (i > 0 || i <= USER_DES)
                {
                    // calling the Next() Method for generating random values
                    
                    int dieInput = random.Next(1, 7);
                    int choice = random.Next(0, 3);
                    

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
                    if (position > USER_DES)
                    {
                        position = position;
                    }
                    else if (position == USER_DES)
                    {
                        break;
                    }
                    else
                    {
                        i++;
                    }
                    count++;

                }

                return count;
            }


        }

    }







}

