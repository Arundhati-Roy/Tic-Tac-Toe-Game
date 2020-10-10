using System;

namespace TicTacToeGame
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");
            char[] board=CreateBoard();
            chooseInput();
            showBoard(board);
        }
        public static char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i=1;i<=10;i++)
            {
                board[i-1] = ' ';
            }
            Console.WriteLine("Board Created");
            return board;
        }
        public static void chooseInput()
        {
            Console.WriteLine("Choose X or O");
            char input = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("You chose " + input);
        }
        public static void showBoard(char[] board)
        {
            Console.WriteLine("\n "+"|"+board[0]+"|"+board[1]+ "|" + board[2]);
            Console.WriteLine("-------");
            Console.WriteLine(" " + "|" + board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine("-------");
            Console.WriteLine(" " + "|" + board[6] + "|" + board[7] + "|" + board[8]);
        }
    }
}
