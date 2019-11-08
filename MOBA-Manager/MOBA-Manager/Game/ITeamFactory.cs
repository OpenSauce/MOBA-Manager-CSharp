using MOBA_Manager.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.Game
{
    interface ITeamFactory
    {
        List<Team> LoadTeams();
        void PopulateTeamsWithPlayers();
    }
}
