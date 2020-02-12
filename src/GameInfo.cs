using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class GameInfo
    {
        public readonly Players players;
        public readonly Boolean isActiveGame;

        public GameInfo(Players players, Boolean isActiveGame)
        {
            this.players = players;
            this.isActiveGame = isActiveGame;
        }

        public GameInfo SwitchNext()
        {
            Players newPlayers = players.SwitchNext();
            return new GameInfo(newPlayers, this.isActiveGame);
        }

        public Player ObtainNextPlayer()
        {
            return players.ObtainNextPlayer();
        }
    }
}
