using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.src
{
    class GameEngine
    {
        private MainGame _mainGame;
        private List<Manager> _managerList;
        private User _player;

        public GameEngine(MainGame mainGame)
        {
            this._mainGame = mainGame;
        }

        public Boolean SetUser(User player)
        {
            _player = player;
            return true;
        }

        public Boolean SetManagerList(List<Manager> managerList)
        {
            _managerList = managerList;
            return true;
        }

        public void Proceed()
        {
            _mainGame.Date = _mainGame.Date.AddDays(1);
            _player.CalculateCash();
        }
    }
}
