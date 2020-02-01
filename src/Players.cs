using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Players
    {
        private IList<Player> players;

        public Players(IList<Player> players)
        {
            this.players = players;
        }

        public Players Add(Player player)
        {
            var clonedPlayers = (Players) this.MemberwiseClone();
            clonedPlayers.players.Add(player);
            return clonedPlayers;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var player in players)
            {
                sb.Append(player + "\n");
            }
            return sb.ToString();
        }
    }
}
