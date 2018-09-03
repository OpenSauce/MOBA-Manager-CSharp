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
        private int _age;
        private String _role;
        private Int64 _salary;

        public MOBAPlayer(String nickname, Team team)
        {
            this._team = team;
            this._nickname = nickname;
        }

        public MOBAPlayer(String nickname, Team team, int age, String role, Int64 salary)
        {
            this._team = team;
            this._nickname = nickname;
            this._age = age;
            this._role = role;
            this._salary = salary;
        }

        public string Nickname { get => _nickname; set => _nickname = value; }
        public int Age { get => _age; set => _age = value; }
        public string Role { get => _role; set => _role = value; }
        public long Salary { get => _salary; set => _salary = value; }
    }
}
