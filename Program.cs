using System;
using System.Data;

public class Program
{
    private static void Main(string[] args)
    {

        Board board = new Board();
        Rules rules = new Rules();
        Player player = new Player();

        //Console.WriteLine("Welcome to Tic Tac Toe!\n\nInstructions: Use the numerical pad to place your tile in the designated place\nExample: 7 = the top left position\n\nPress 'Enter' to continue");
        //Console.ReadLine();

        bool gameOver = false;
        while (!gameOver)
        {

            // PLayer 1 turn
            Turn(player.player1Name, player.player1Tile);

            // PLayer 2 turn
            Turn(player.player2Name, player.player2Tile);

        }

        void Turn(string playerName, string playerTile)
        {
            Console.Clear();

            Console.WriteLine($" It is {playerName}'s turn\n");

            board.Results();

            Console.WriteLine("\n What tile do you want to play?");
            var playerInput = Convert.ToString(Console.ReadLine());

            RangeValidation(playerInput, playerName, playerTile);

            board.Update(playerInput, playerTile);
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

    }

    class Rules
    {    
    
        // start with player1
        // display board
        // player1 inputs tile
        // validate tile selection
        // output player1's selection
        // update board
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
                    if (pos1 == " ")
                    {
                        pos1 = currentPlayer;
                    }
                    else
                    {
                        //Console.WriteLine("That tile is already taken");
                        //Console.WriteLine("\n What tile do you want to play?");
                        //playerInput = Convert.ToString(Console.ReadLine());
                    }
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

        //what else?

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


