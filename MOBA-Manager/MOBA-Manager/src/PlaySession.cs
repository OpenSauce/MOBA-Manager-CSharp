using System.Collections;
using System.Collections.Generic;

namespace MOBA_Manager
{
    public class PlaySession
    {
        private List<MOBAPlayer>  _totalPlayerList;
        private List<Team> _totalTeamList;

        public List<MOBAPlayer> TotalPlayerList { get => _totalPlayerList; set => _totalPlayerList = value; }

        public PlaySession() 
        {
            _totalPlayerList = new List<MOBAPlayer>();
            _totalTeamList = new List<Team>();
        }

        public void AddPlayerToSession(MOBAPlayer player) 
        {
            if(player != null)
            {
                _totalPlayerList.Add(player);
            }
        }

        public List<MOBAPlayer> GetPlayerList() 
        {
            return _totalPlayerList;
        }

        public MOBAPlayer GetPlayerIndex(int index)
        {
            return _totalPlayerList[index];
        }

        public void AddTeamToSession(Team team) 
        {
            if(team != null) 
            {
                _totalTeamList.Add(team);
            }                          
        }

        public List<Team> GetTeamList() 
        {
            return _totalTeamList;
        }

    }
}