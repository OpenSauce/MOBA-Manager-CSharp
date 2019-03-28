using System.Collections;
using System.Collections.Generic;

namespace MOBA_Manager
{
    public class PlaySession
    {
        private List<MOBAPlayer>  totalPlayerList;
        private List<Team> totalTeamList;

        public PlaySession() 
        {
            totalPlayerList = new List<MOBAPlayer>();
            totalTeamList = new List<Team>();
        }

        public void AddPlayerToSession(MOBAPlayer player) 
        {
            if(player != null)
            {
                totalPlayerList.Add(player);
            }
        }

        public List<MOBAPlayer> GetPlayerList() 
        {
            return totalPlayerList;
        }

        public void AddTeamToSession(Team team) 
        {
            if(team != null) 
            {
                totalTeamList.Add(team);
            }                          
        }

        public List<Team> GetTeamList() 
        {
            return totalTeamList;
        }

    }
}