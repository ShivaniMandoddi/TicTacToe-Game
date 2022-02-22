using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        
        public static char[,] playField = { { '1', '2', '3' }, //Row0
                                { '4', '5', '6' }, //Row1
                                { '7', '8', '9' } }; //Row2
        
        static void Main(string[] args)
        {   
        
            int player = 2;
            int input = 0;
            string check = " ";

            ResetGame:
            bool correctInput = true;
            bool win = false;
            int i=49;
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    playField[k,j] = Convert.ToChar(i);
                    i++;
                }
            }
     
            do
            {
               
                    if (player == 2)
                        player = 1;
                    else if (player == 1)
                        player = 2;
                    DrawBoard();
                #region
                //To check winning condition
                char[] playerChar = {'X','O'};
                foreach (var item in playerChar)
                {
                    if((playField[0,0] ==item && playField[0,1]==item && playField[0,2]==item) ||
                        (playField[1, 0] == item && playField[1, 1] == item && playField[1, 2] == item) ||
                        (playField[2, 0] == item && playField[2, 1] == item && playField[2, 2] == item) ||
                        (playField[0, 0] == item && playField[1, 0] == item && playField[2, 0] == item) ||
                        (playField[0, 1] == item && playField[1, 1] == item && playField[2, 1] == item) ||
                        (playField[0, 2] == item && playField[1, 2] == item && playField[2, 2] == item) ||
                        (playField[0, 0] == item && playField[1, 1] == item && playField[2, 2] == item) ||
                        (playField[0, 2] == item && playField[1, 1] == item && playField[2, 0] == item))
                    {

                        if (item == 'X')
                            Console.WriteLine("Player1 is the Winner");
                        else if (item == 'O')
                            Console.WriteLine("Player2 is the Winner");
                        Console.WriteLine("Press yes to Reset the game and no to Stop the game");
                        check = Console.ReadLine();
                        win = true;
                        break;
                    }                   
                }
                if(win)
                {
                    if (check == "yes")
                        goto ResetGame;
                    else if (check == "no")
                        break;
                 }
                #endregion
                #region
                // This region is to check the field is occupied or not
                do
                {
                    Console.WriteLine("\nPlayer{0}, Choose the field",player);
                    
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Enter between 0 and 9");
                    }
                    if (input == 1 && playField[0, 0] == '1') // when we use same field
                    {
                        correctInput = true;
                    }
                    else if (input == 2 && playField[0, 1] == '2')
                    {
                        correctInput = true;
                    }
                    else if (input == 3 && playField[0, 2] == '3')
                    {
                        correctInput = true;
                    }
                    else if (input == 4 && playField[1, 0] == '4')
                    {
                        correctInput = true;
                    }
                    else if (input == 5 && playField[1, 1] == '5')
                    {
                        correctInput = true;
                    }
                    else if (input == 6 && playField[1, 2] == '6')
                    {
                        correctInput = true;
                    }
                    else if (input == 7 && playField[2, 0] == '7')
                    {
                        correctInput = true;
                    }
                    else if (input == 8 && playField[2, 1] == '8')
                    {
                        correctInput = true;
                    }
                    else if (input == 9 && playField[2, 2] == '9')
                    {
                        correctInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please give in another field\n");
                        correctInput = false;
                    }
                } while (!correctInput);
                #endregion
                EnterXorO(player, input);
            } while (true);
            Console.WriteLine("ThankYou");
            
            Console.ReadLine();
        }

        private static void EnterXorO(int player,int input)
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';
           
                switch (input)
                    {
                        case 1:
                            playField[0, 0] = playerSign;
                            break;
                        case 2:
                            playField[0, 1] = playerSign;
                            break;
                        case 3:
                            playField[0, 2] = playerSign;
                            break;
                        case 4:
                            playField[1, 0] = playerSign;
                            break;
                        case 5:
                            playField[1, 1] = playerSign;
                            break;
                        case 6:
                            playField[1, 2] = playerSign;
                            break;
                        case 7:
                            playField[2, 0] = playerSign;
                            break;
                        case 8:
                            playField[2, 1] = playerSign;
                            break;
                        case 9:
                            playField[2, 2] = playerSign;
                            break;
                        default:
                            break;
                    }
        }

        private static void DrawBoard()
        {
            //This is a method to draw 3*3 Board
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ",playField[0,0],playField[0,1],playField[0,2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("   |   |   ");
            
        }
    }
}
