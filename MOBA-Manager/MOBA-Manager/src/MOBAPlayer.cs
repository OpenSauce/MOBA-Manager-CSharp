using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.src
{
    public class MOBAPlayer
    {
        private Team _team;
        private String _nickname;

        public MOBAPlayer(String nickname, Team team)
        {
            this._team = team;
            this._nickname = nickname;
        }

        public String GetNickname()
        {
            return _nickname;
        }
    }
}
