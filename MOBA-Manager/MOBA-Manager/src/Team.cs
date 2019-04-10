using MOBA_Manager.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager
{
    public class Team : MOBATeam
    {
        protected String _teamName;
        protected List<MOBAPlayer> _squad;

        public Team(String teamName) 
        {
            this._squad = new List<MOBAPlayer>();
            this._teamName = teamName;
        }

        public String GetTeamName()
        {
            return _teamName;
        }

        public List<MOBAPlayer> GetSquad()
        {
            return _squad;
        }

        public MOBAPlayer GetPlayer(MOBAPlayer player)
        {
            MOBAPlayer chosenplayer = null;
            foreach(var MOBAPlayer in _squad) {
                if(player == MOBAPlayer)
                {
                    chosenplayer = MOBAPlayer;
                }
            }
            return chosenplayer;
        }

        public MOBAPlayer GetPlayerIndex(int index)
        {
            return _squad[index];
        }

        public Boolean AddPlayer(MOBAPlayer player)
        {
            if(_squad.Count <= 7)
            {
                _squad.Add(player);
                return true;
            }
            return false;
        }
    }
}
