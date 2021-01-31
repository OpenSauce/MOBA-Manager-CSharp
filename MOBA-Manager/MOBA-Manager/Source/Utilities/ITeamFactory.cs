using MOBA_Manager.DataModel;
using System.Collections.Generic;

namespace MOBA_Manager.Game
{
    internal interface ITeamFactory
    {
        List<Team> LoadTeams();

        void PopulateTeamsWithPlayers();
    }
}