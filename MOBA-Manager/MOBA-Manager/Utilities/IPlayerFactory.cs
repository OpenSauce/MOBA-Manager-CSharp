using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOBA_Manager.DataModel;

namespace MOBA_Manager.Game
{
    interface IPlayerFactory
    {
        List<Player> LoadPlayers();
    }
}
