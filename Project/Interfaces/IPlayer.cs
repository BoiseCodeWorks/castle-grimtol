using System.Collections.Generic;

namespace CastleGrimtol.Project
{
  public interface IPlayer
  {
    string PlayerName { get; set; }
    List<IItem> Inventory { get; set; }
  }
}
