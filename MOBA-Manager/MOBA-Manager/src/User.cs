using MOBA_Manager.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager
{

    public class User : Manager
    {
        private bool _created = false;
        private List<NewsPost> _newsPosts;

        public User(String name, int age, bool created)
        {
            this._name = name;
            this._age = age;
            this._created = created;
            this._newsPosts = new List<NewsPost>();
        }

        public List<NewsPost> NewsPosts { get => _newsPosts; set => _newsPosts = value; }

        public void AddNews(NewsPost post)
        {
            _newsPosts.Add(post);
        }

        public Boolean IsCreated()
        {
            return _created;
        }

        public void CalculateCash()
        {
            foreach(MOBAPlayer player in _team.GetSquad())
            {
                _netIncome -= player.Salary / 52;
            }

            _cash += _netIncome;
        }

    }
}
