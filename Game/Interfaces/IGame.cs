using System.Collections.Generic;

namespace CastleGrimtol.Game
{
    public interface IGame
    {
        int Score { get; set; }

        Room CurrentRoom { get; set; }
        Player CurrentPlayer { get; set; }

        void Setup();
        void StartGame();
        void Reset();
        string GetUserInput();

        //No need to Pass a room since Items can only be used in the CurrentRoom
        void UseItem(string itemName);

    }
}