using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Helper
{
    public class Player
    {
        public string PlayerName { get; set; }
        public string PlayerTile { get; set; }

        public Player(string playerName, string playerTile)
        {
            this.PlayerName = playerName;
            this.PlayerTile = playerTile;
        }
    }
}
