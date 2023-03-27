using System;
using System.Data;
using System.Numerics;

public class Program
{
    public static bool safe;

    private static void Main(string[] args)
    {

        Board board = new Board();
        Player player = new Player();

        Console.WriteLine("Welcome to Tic Tac Toe!\n\nInstructions: Use the numerical pad to place your tile in the designated place\nExample: 7 = the top left position\n\nPress 'Enter' to continue");
        Console.ReadLine();

        // setup names
        Console.WriteLine("What is Player 1's name");
        var askP1 = Console.ReadLine();
        player.player1Name = askP1;

        Console.WriteLine("What is Player 2's name");
        var askP2 = Console.ReadLine();
        player.player2Name = askP2;

        // start game
        bool gameOver = false;
        while (!gameOver)
        {

            // Player 1 turn
            Turn(player.player1Name, player.player1Tile);

            //TieGame();
            HasWon(player.player1Name);
            TieGame();
            if (gameOver) { break; }

            // Player 2 turn
            Turn(player.player2Name, player.player2Tile);

            //TieGame();
            HasWon(player.player2Name);
            TieGame();
            if (gameOver) { break; }

        }

        void Turn(string playerName, string playerTile)
        {
            Console.Clear();

            Console.WriteLine($" It is {playerName}'s turn\n");

            board.Results();

            Console.WriteLine("\n What tile do you want to play?");
            var playerInput = Convert.ToString(Console.ReadLine());

            RangeValidation(playerInput, playerName, playerTile);

            TileValidation(playerInput, playerName, playerTile);
        }

        void HasWon(string playerName)
        {
            if(board.pos1 == player.player1Tile && board.pos2 == player.player1Tile && board.pos3 == player.player1Tile) Won(playerName);
            if (board.pos4 == player.player1Tile && board.pos5 == player.player1Tile && board.pos6 == player.player1Tile) Won(playerName);
            if (board.pos7 == player.player1Tile && board.pos8 == player.player1Tile && board.pos9 == player.player1Tile) Won(playerName);
            if (board.pos7 == player.player1Tile && board.pos4 == player.player1Tile && board.pos1 == player.player1Tile) Won(playerName);
            if (board.pos8 == player.player1Tile && board.pos5 == player.player1Tile && board.pos2 == player.player1Tile) Won(playerName);
            if (board.pos9 == player.player1Tile && board.pos6 == player.player1Tile && board.pos3 == player.player1Tile) Won(playerName);
            if (board.pos7 == player.player1Tile && board.pos5 == player.player1Tile && board.pos3 == player.player1Tile) Won(playerName);
            if (board.pos9 == player.player1Tile && board.pos5 == player.player1Tile && board.pos1 == player.player1Tile) Won(playerName);
            if (board.pos1 == player.player2Tile && board.pos2 == player.player2Tile && board.pos3 == player.player2Tile) Won(playerName);
            if (board.pos4 == player.player2Tile && board.pos5 == player.player2Tile && board.pos6 == player.player2Tile) Won(playerName);
            if (board.pos7 == player.player2Tile && board.pos8 == player.player2Tile && board.pos9 == player.player2Tile) Won(playerName);
            if (board.pos7 == player.player2Tile && board.pos4 == player.player2Tile && board.pos1 == player.player2Tile) Won(playerName);
            if (board.pos8 == player.player2Tile && board.pos5 == player.player2Tile && board.pos2 == player.player2Tile) Won(playerName);
            if (board.pos9 == player.player2Tile && board.pos6 == player.player2Tile && board.pos3 == player.player2Tile) Won(playerName);
            if (board.pos7 == player.player2Tile && board.pos5 == player.player2Tile && board.pos3 == player.player2Tile) Won(playerName);
            if (board.pos9 == player.player2Tile && board.pos5 == player.player2Tile && board.pos1 == player.player2Tile) Won(playerName);
        }

        void Won(string playerName)
        {
            Console.Clear();
            board.Results();
            Console.WriteLine($"\n{playerName} is the WINNER!");
            gameOver = true;
        }

        void TieGame()
        {
            if (board.pos1 != " " && board.pos2 != " " && board.pos3 != " " && board.pos4 != " " && board.pos5 != " " && board.pos6 != " " && board.pos7 != " " && board.pos8 != " " && board.pos9 != " ")
            {
                Console.Clear();
                board.Results();
                Console.WriteLine("DRAW GAME!");
                gameOver = true;
            }
        }

        string RangeValidation(string playerInput, string playerName, string playerTile) // validate range is between 1 and 9
        {
            int playerInputConvert = Convert.ToInt32(playerInput);

            while (playerInputConvert < 1 || playerInputConvert > 9)
            {
                Console.Clear();
                
                Console.WriteLine("Please input a number between 1 and 9.");
                
                Console.WriteLine("Press 'Enter' to continue");
                
                Console.ReadLine();

                Turn(playerName, playerTile);

                return playerInput;
            }
            return playerInput;
        }

        void TileValidation(string playerInput, string playerName, string playerTile)
        {
            int playerInputConvert = Convert.ToInt32(playerInput);

            switch (playerInputConvert)
            {
                case 1:
                    if (board.pos1 == player.player1Tile || board.pos1 == player.player2Tile)
                    {
                       Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 2:
                    if (board.pos2 == player.player1Tile || board.pos2 == player.player2Tile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 3:
                    if (board.pos3 == player.player1Tile || board.pos3 == player.player2Tile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 4:
                    if (board.pos4 == player.player1Tile || board.pos4 == player.player2Tile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 5:
                    if (board.pos5 == player.player1Tile || board.pos5 == player.player2Tile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 6:
                    if (board.pos6 == player.player1Tile || board.pos6 == player.player2Tile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 7:
                    if (board.pos7 == player.player1Tile || board.pos7 == player.player2Tile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 8:
                    if (board.pos8 == player.player1Tile || board.pos8 == player.player2Tile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 9:
                    if (board.pos9 == player.player1Tile || board.pos9 == player.player2Tile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
            }
        }

        void Rules(string playerName, string playerTile)
        {
            Console.Clear();

            Console.WriteLine("That tile is already claimed. Please select a differnt one.");

            Console.WriteLine("Press 'Enter' to continue");

            Console.ReadLine();

            Turn(playerName, playerTile);
        }

    }

    class Board
    {
        public string pos1 { get; set; }
        public string pos2 { get; set; }
        public string pos3 { get; set; }
        public string pos4 { get; set; }
        public string pos5 { get; set;}
        public string pos6 { get; set;}
        public string pos7 { get; set;}
        public string pos8 { get; set; }
        public string pos9 { get; set; }

        public Board() //used to setup the game board
        {
            pos1 = " ";
            pos2 = " ";
            pos3 = " ";
            pos4 = " ";
            pos5 = " ";
            pos6 = " ";
            pos7 = " ";
            pos8 = " ";
            pos9 = " ";
        }


        public void Results() // display current game board results
        {
            Console.WriteLine(@$" {pos7} | {pos8} | {pos9} " +
                                "\n---+---+---\n" +
                               $" {pos4} | {pos5} | {pos6} " +
                                "\n---+---+---\n" +
                               $" {pos1} | {pos2} | {pos3} ");

        }

        public string Update(string playerInput, string currentPlayer) // set new tile for game board
        {
            switch (playerInput)
            {
                case "1":
                    pos1 = currentPlayer;
                    break;
                case "2":
                    pos2 = currentPlayer;
                    break;
                case "3":
                    pos3 = currentPlayer;
                    break;
                case "4":
                    pos4 = currentPlayer;
                    break;
                case "5":
                    pos5 = currentPlayer;
                    break;
                case "6":
                    pos6 = currentPlayer;
                    break;
                case "7":
                    pos7 = currentPlayer;
                    break;
                case "8":
                    pos8 = currentPlayer;
                    break;
                case "9":
                    pos9 = currentPlayer;
                    break;
            }
            return playerInput;
        }

    }

    class Player
    {
        public string player1Name { get; set; }
        public string player1Tile { get; set; }
        public string player2Name { get; set; }
        public string player2Tile { get; set; }


        public Player()
        {
            player1Name = "Player 1";
            player1Tile = "X";
            player2Name = "Player 2";
            player2Tile = "O";
        }

        //what else? scores?

    }

    class Score 
    {

        public Score() { }
    }

    class GameStatus
    {

        public bool gameOver;
    }
}