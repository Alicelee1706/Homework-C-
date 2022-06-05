using System;

namespace Sampe2_Tic_Tac_Toe
{
    internal class Program
    {
        static char[] board = { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-'};
        static int player = 1;
        static char playerChar1 = 'X';
        static char playerChar2 = 'O';
        static int pos;
      

        static void Main(string[] args)
        {
            Console.WriteLine("TicTacToe Version 0.0");
            Console.WriteLine("Player 1 ({0}) vs Player 2 ({1})", playerChar1, playerChar2);

            table();



            /*for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    Console.Write("Position player {0} go: ", j);
                    pos = Convert.ToInt32(Console.ReadLine());
                    if (j % 2 == 0)
                    {
                        board[pos] = playerChar2;
                    }
                    else
                    {
                        board[pos] = playerChar1;
                    }
                }
                goto tt;
            }*/
        }
        private static char getPlayerChar(char c)
        {
            if (c == '-')
            {
                return ' ';
            }
            return c;
        }
        private static void table()
        {
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", getPlayerChar(board[1]), getPlayerChar(board[2]), getPlayerChar(board[3]));
            Console.WriteLine("|     |     |     |");
            Console.WriteLine(" _____ _____ _____ ");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", getPlayerChar(board[4]), getPlayerChar(board[5]), getPlayerChar(board[6]));
            Console.WriteLine("|     |     |     |");
            Console.WriteLine(" _____ _____ _____ ");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", getPlayerChar(board[7]), getPlayerChar(board[8]), getPlayerChar(board[9]));
            Console.WriteLine("|     |     |     |");
            Console.WriteLine(" _____ _____ _____ ");
        }
    }
}
