using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public interface IPlayer
    {
        int Score { get; set; }
        List<Item> Inventory { get; set; }

    }
}