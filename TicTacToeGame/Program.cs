using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");
            CreateBoard();
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
    }
}
