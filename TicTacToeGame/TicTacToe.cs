using System;

namespace TicTacToeGame
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");
            CreateBoard();
            chooseInput();
        }
        public static void CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i <= 10; i++)
            {
                board[i - 1] = ' ';
            }
            Console.WriteLine("Board Created");
        }
        public static void chooseInput()
        {
            Console.WriteLine("Choose X or O");
            string input = (Console.ReadLine());
            bool val = true;
            while (val)
            {
                Console.WriteLine("Choose X or O");
                input = (Console.ReadLine());
                if (char.ToUpper(input[0]) == 'X' | char.ToUpper(input[0]) == 'O')
                {
                    Console.WriteLine("You chose " + char.ToUpper(input[0]));
                    val = false;
                }
                else
                    Console.WriteLine("Invalid Input");
            }
        }
    }
}
