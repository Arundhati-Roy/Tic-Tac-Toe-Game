using System;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToeGame
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");
            char[] board = CreateBoard();
            showBoard(board);
            getHeadTail(board);
            //isWinner(board, chooseInput());
        }
        public static char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i <= 10; i++)
            {
                board[i - 1] = ' ';
            }
            Console.WriteLine("Board Created");
            return board;
        }
        public static char chooseInput()
        {
            string input = "";
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
            Console.WriteLine("\n " + "|" + board[0] + "|" + board[1] + "|" + board[2] + "|");
            Console.WriteLine("-------");
            Console.WriteLine(" " + "|" + board[3] + "|" + board[4] + "|" + board[5] + "|");
            Console.WriteLine("-------");
            Console.WriteLine(" " + "|" + board[6] + "|" + board[7] + "|" + board[8] + "|");
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
        public static void getHeadTail(char[] board)
        {
            Random random = new Random();
            int toss = random.Next(0, 2);
            if (toss == 0)
            {
                Console.WriteLine("You go first");
                getBoxNum(board);
            }
            else
            {
                Console.WriteLine("Computer goes first");
                //getBoxNum(board);
                string input = "XO";
                if (board[random.Next(1, 10)] == ' ')
                {
                    board[random.Next(1, 10)] = input[random.Next(0, 2)];
                }
                else
                    Console.WriteLine("Index already taken");
                showBoard(board);
            }
        }
        public static bool isWinner(char[] b, char ch)
        {
            return ((b[0] == ch && b[1] == ch && b[2] == ch) ||  //top row
                    (b[3] == ch && b[4] == ch && b[5] == ch) ||  //middle row
                    (b[6] == ch && b[7] == ch && b[8] == ch) ||  //bottom row
                    (b[0] == ch && b[3] == ch && b[6] == ch) ||  //first column
                    (b[1] == ch && b[4] == ch && b[7] == ch) ||  //second column
                    (b[2] == ch && b[5] == ch && b[8] == ch) ||  //third column
                    (b[0] == ch && b[4] == ch && b[8] == ch) ||  //first diagonal
                    (b[2] == ch && b[4] == ch && b[6] == ch)     //second diagonal
                );
        }

    }
}
