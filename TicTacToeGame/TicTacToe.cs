using System;

namespace TicTacToeGame
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");
            char[] board=CreateBoard();
            //char input = chooseInput();
            showBoard(board);
            getBoxNum(board);
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
        public static char chooseInput()
        {
            string input="";
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
            return char.ToUpper(input[0]);
        }
        public static void showBoard(char[] board)
        {
            Console.WriteLine("\n "+"|"+board[0]+"|"+board[1]+ "|" + board[2]);
            Console.WriteLine("-------");
            Console.WriteLine(" " + "|" + board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine("-------");
            Console.WriteLine(" " + "|" + board[6] + "|" + board[7] + "|" + board[8]);
        }
        public static void getBoxNum(char[] board)
        {
            int[] box = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Where do you wanna enter(1-9): ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (board[index - 1] == ' ')
            {
                board[index - 1] = chooseInput();
            }
            else
                Console.WriteLine("Index already taken");
            showBoard(board);
        }
        
    }
}
