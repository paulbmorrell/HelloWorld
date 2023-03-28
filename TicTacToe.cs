using System;

public class TicTacToe
{
    private static void Main(string[] args)
    {
        Board board = new Board();
        Player player1 = new Player("Player1", "X");
        Player player2 = new Player("Player2", "0");

        // output game info
        Console.WriteLine("Welcome to Tic Tac Toe!\n\nInstructions: Use the numerical pad to place your tile in the designated place\nExample: 7 = the top left position\n\nPress 'Enter' to continue");
        Console.ReadLine();

        // setup names
        Console.Clear();
        Console.WriteLine("What is Player 1's name");
        var askP1 = Console.ReadLine();
        player1.playerName = askP1;

        Console.Clear();
        Console.WriteLine("What is Player 2's name");
        var askP2 = Console.ReadLine();
        player2.playerName = askP2;

        // start game
        bool gameOver = false;
        int drawGame = 0;
        Player currentPlayer = player1;
        while (drawGame < 9)
        {
            // player turn
            Turn(currentPlayer.playerName, currentPlayer.playerTile);
            WinStatus(currentPlayer.playerName, currentPlayer.playerTile);
            if (gameOver) { break; } 

            // change player
            currentPlayer = currentPlayer == player1 ? player2 : player1;
            drawGame++;
        }

        // if no winner
        if (!gameOver) TieGame();

        // player turn steps
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

        // validate if player has won
        void WinStatus(string playerName, string playerTile)
        {
            // check horizontals
            if(board.pos1 == playerTile && board.pos2 == playerTile && board.pos3 == playerTile) WonGame(playerName);
            if (board.pos4 == playerTile && board.pos5 == playerTile && board.pos6 == playerTile) WonGame(playerName);
            if (board.pos7 == playerTile && board.pos8 == playerTile && board.pos9 == playerTile) WonGame(playerName);
            
            // check verticals
            if (board.pos7 == playerTile && board.pos4 == playerTile && board.pos1 == playerTile) WonGame(playerName);
            if (board.pos8 == playerTile && board.pos5 == playerTile && board.pos2 == playerTile) WonGame(playerName);
            if (board.pos9 == playerTile && board.pos6 == playerTile && board.pos3 == playerTile) WonGame(playerName);
            
            // check diagonals
            if (board.pos7 == playerTile && board.pos5 == playerTile && board.pos3 == playerTile) WonGame(playerName);
            if (board.pos9 == playerTile && board.pos5 == playerTile && board.pos1 == playerTile) WonGame(playerName);
        }

        // output winner
        void WonGame(string playerName)
        {
            Console.Clear();
            Console.WriteLine($"{playerName} is the Winner!\n");
            board.Results();
            gameOver = true;
        }

        // output draw
        void TieGame()
        {
            Console.Clear();
            Console.WriteLine("---Draw Grame---\n");
            board.Results();
        }

        // validate player input is acceptable 
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

        // validate tile is not already claimed
        void TileValidation(string playerInput, string playerName, string playerTile)
        {
            int playerInputConvert = Convert.ToInt32(playerInput);

            switch (playerInputConvert)
            {
                case 1:
                    if (board.pos1 == player1.playerTile || board.pos1 == player2.playerTile)
                    {
                       Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 2:
                    if (board.pos2 == player1.playerTile || board.pos2 == player2.playerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 3:
                    if (board.pos3 == player1.playerTile || board.pos3 == player2.playerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 4:
                    if (board.pos4 == player1.playerTile || board.pos4 == player2.playerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 5:
                    if (board.pos5 == player1.playerTile || board.pos5 == player2.playerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 6:
                    if (board.pos6 == player1.playerTile || board.pos6 == player2.playerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 7:
                    if (board.pos7 == player1.playerTile || board.pos7 == player2.playerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 8:
                    if (board.pos8 == player1.playerTile || board.pos8 == player2.playerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 9:
                    if (board.pos9 == player1.playerTile || board.pos9 == player2.playerTile)
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

        // if tile is claimed do this
        void Rules(string playerName, string playerTile)
        {
            Console.Clear();

            Console.WriteLine("That tile is already claimed. Please select a different one.");

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

        public string Update(string playerInput, string PlayerTile) // set new tile for game board
        {
            switch (playerInput)
            {
                case "1":
                    pos1 = PlayerTile;
                    break;
                case "2":
                    pos2 = PlayerTile;
                    break;
                case "3":
                    pos3 = PlayerTile;
                    break;
                case "4":
                    pos4 = PlayerTile;
                    break;
                case "5":
                    pos5 = PlayerTile;
                    break;
                case "6":
                    pos6 = PlayerTile;
                    break;
                case "7":
                    pos7 = PlayerTile;
                    break;
                case "8":
                    pos8 = PlayerTile;
                    break;
                case "9":
                    pos9 = PlayerTile;
                    break;
            }
            return playerInput;
        }
    }

    class Player
    {
        public string playerName { get; set; }
        public string playerTile { get; set; }

        public Player(string playerName, string playerTile)
        {
            this.playerName = playerName;
            this.playerTile = playerTile;
        }
    }
}