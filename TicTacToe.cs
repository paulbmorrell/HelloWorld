using System;
using HelloWorld.Helper;

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
        player1.PlayerName = askP1;

        Console.Clear();
        Console.WriteLine("What is Player 2's name");
        var askP2 = Console.ReadLine();
        player2.PlayerName = askP2;

        // start game
        bool gameOver = false;
        int drawGame = 0;
        Player currentPlayer = player1;
        while (drawGame < 9)
        {
            // player turn
            Turn(currentPlayer.PlayerName, currentPlayer.PlayerTile);
            WinStatus(currentPlayer.PlayerName, currentPlayer.PlayerTile);
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
            if(board.Pos1 == playerTile && board.Pos2 == playerTile && board.Pos3 == playerTile) WonGame(playerName);
            if (board.Pos4 == playerTile && board.Pos5 == playerTile && board.Pos6 == playerTile) WonGame(playerName);
            if (board.Pos7 == playerTile && board.Pos8 == playerTile && board.Pos9 == playerTile) WonGame(playerName);
            
            // check verticals
            if (board.Pos7 == playerTile && board.Pos4 == playerTile && board.Pos1 == playerTile) WonGame(playerName);
            if (board.Pos8 == playerTile && board.Pos5 == playerTile && board.Pos2 == playerTile) WonGame(playerName);
            if (board.Pos9 == playerTile && board.Pos6 == playerTile && board.Pos3 == playerTile) WonGame(playerName);
            
            // check diagonals
            if (board.Pos7 == playerTile && board.Pos5 == playerTile && board.Pos3 == playerTile) WonGame(playerName);
            if (board.Pos9 == playerTile && board.Pos5 == playerTile && board.Pos1 == playerTile) WonGame(playerName);
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
                    if (board.Pos1 == player1.PlayerTile || board.Pos1 == player2.PlayerTile)
                    {
                       Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 2:
                    if (board.Pos2 == player1.PlayerTile || board.Pos2 == player2.PlayerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 3:
                    if (board.Pos3 == player1.PlayerTile || board.Pos3 == player2.PlayerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 4:
                    if (board.Pos4 == player1.PlayerTile || board.Pos4 == player2.PlayerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 5:
                    if (board.Pos5 == player1.PlayerTile || board.Pos5 == player2.PlayerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 6:
                    if (board.Pos6 == player1.PlayerTile || board.Pos6 == player2.PlayerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 7:
                    if (board.Pos7 == player1.PlayerTile || board.Pos7 == player2.PlayerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 8:
                    if (board.Pos8 == player1.PlayerTile || board.Pos8 == player2.PlayerTile)
                    {
                        Rules(playerName, playerTile);
                    }
                    else
                    {
                        board.Update(playerInput, playerTile);
                    }
                    break;
                case 9:
                    if (board.Pos9 == player1.PlayerTile || board.Pos9 == player2.PlayerTile)
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
}