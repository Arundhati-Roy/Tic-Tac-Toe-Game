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
            for (int i=1;i<=10;i++)
            {
                board[i-1] = ' ';
            }
            Console.WriteLine("Board Created");
        }
        public static void chooseInput()
        {
            Console.WriteLine("Choose X or O");
            char input = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("You chose " + input);
        }
    }
}
