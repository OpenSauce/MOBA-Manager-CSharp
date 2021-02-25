using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.Source.Game
{
    public interface iState
    {
        void Enter();
        void Execute();
        void Exit();
    }
}
