using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Helper
{
    public class Board
    {
        public string Pos1 { get; set; }
        public string Pos2 { get; set; }
        public string Pos3 { get; set; }
        public string Pos4 { get; set; }
        public string Pos5 { get; set; }
        public string Pos6 { get; set; }
        public string Pos7 { get; set; }
        public string Pos8 { get; set; }
        public string Pos9 { get; set; }

        public Board() //used to setup the game board
        {
            Pos1 = " ";
            Pos2 = " ";
            Pos3 = " ";
            Pos4 = " ";
            Pos5 = " ";
            Pos6 = " ";
            Pos7 = " ";
            Pos8 = " ";
            Pos9 = " ";
        }

        // read the PlayerName

        public void Results() // display current game board results
        {
            Console.WriteLine(@$" {Pos7} | {Pos8} | {Pos9} " +
                                "\n---+---+---\n" +
                               $" {Pos4} | {Pos5} | {Pos6} " +
                                "\n---+---+---\n" +
                               $" {Pos1} | {Pos2} | {Pos3} ");
        }

        public string Update(string playerInput, string PlayerTile) // set new tile for game board
        {
            switch (playerInput)
            {
                case "1":
                    Pos1 = PlayerTile;
                    break;
                case "2":
                    Pos2 = PlayerTile;
                    break;
                case "3":
                    Pos3 = PlayerTile;
                    break;
                case "4":
                    Pos4 = PlayerTile;
                    break;
                case "5":
                    Pos5 = PlayerTile;
                    break;
                case "6":
                    Pos6 = PlayerTile;
                    break;
                case "7":
                    Pos7 = PlayerTile;
                    break;
                case "8":
                    Pos8 = PlayerTile;
                    break;
                case "9":
                    Pos9 = PlayerTile;
                    break;
            }
            return playerInput;
        }
    }
}
