namespace MOBA_Manager.Source.Game
{
    public interface iState
    {
        void Enter();

        void Execute();

        void Exit();
    }
}