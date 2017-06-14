using System.Collections.Generic;

namespace CastleGrimtol.Game
{
    public interface IPlayer
    {
        int Score { get; set; }
        List<Item> Inventory { get; set; }

    }
}