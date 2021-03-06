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
            var newList = new List<Player>(this.players);
            newList.Add(player);
            return new Players(newList);
        }

        public Players SwitchNext()
        {
            if (players[0].isNext == true)
            {
                players[0].isNext = false;
                players[1].isNext = true;
            }
            else
            {
                players[0].isNext = true;
                players[1].isNext = false;
            }
            IList<Player> newPlayers = new List<Player>(players);
            return new Players(newPlayers);
        }

        public Player ObtainNextPlayer()
        {
            if (this.players[0].isNext)
            {
                return this.players[0];
            }

            return this.players[1];
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
