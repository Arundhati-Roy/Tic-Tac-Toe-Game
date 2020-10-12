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
            //char userLetter = chooseInput();
            string input =getHeadTail(board);
            char userLetter = input[0];
            char compLetter = input[1];
            int comp = getCompMove(board,compLetter,userLetter);
            showBoard(board);
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
        public static char chooseInput(char[] board)
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
                    getBoxNum(board, char.ToUpper(input[0]));
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
        public static void getBoxNum(char[] board, char userinput)
        {
            int[] box = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Where do you wanna enter(1-9): ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (board[index - 1] == ' ')
            {
                board[index - 1] = userinput;
            }
            else
                Console.WriteLine("Index already taken");
            showBoard(board);
            //return userinput;
        }
        public static string getHeadTail(char[] board)
        {
            int compIndex;
            char userLetter;
            string compLetter;
            string str = "XO";
            Random random = new Random();
            int toss = random.Next(0, 2);
            if (toss == 0)
            {
                Console.WriteLine("You go first");
                userLetter =chooseInput(board);
                compLetter = str.Trim(trimChar: userLetter);
            }
            else
            {
                Console.WriteLine("Computer goes first");
                compIndex=random.Next(0, 2);
                compLetter = Convert.ToString(str[compIndex]);
                board[random.Next(1, 10)] = str[compIndex];
                Console.WriteLine("You got "+str.Trim(trimChar: str[compIndex]));
                userLetter = str[compIndex-1];
            }
            return Convert.ToString(userLetter) + compLetter;
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
        public static int getCompMove(char[] board,char compLetter,char userLetter)
        {
            int compMove = getWinningMove(board, compLetter);
            if (compMove!= 0) return compMove;
            int userMove = getWinningMove(board, userLetter);
            if (userMove != 0) return userMove;
            return 0;
        }
        public static int getWinningMove(char[] board, char letter)
        {
            for (int i = 0; i < 9; i++)
            {
                char[] copyBoard = board;
                if (copyBoard[i] == ' ')
                {
                    copyBoard[i] = letter;
                    if (isWinner(board, letter))
                        return i;
                }
            }
            return 0;
        }
    }
}
