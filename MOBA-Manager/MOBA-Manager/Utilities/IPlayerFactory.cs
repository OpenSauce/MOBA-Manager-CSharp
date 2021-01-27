using MOBA_Manager.DataModel;
using System.Collections.Generic;

namespace MOBA_Manager.Game
{
    internal interface IPlayerFactory
    {
        List<Player> LoadPlayers();
    }
}