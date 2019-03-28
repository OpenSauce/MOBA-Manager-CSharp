namespace MOBA_Manager
{
    public class PlaySession
    {
        ArrayList<MOBAPlayer>  totalPlayerList;

        public PlaySession() 
        {
            totalPlayerList = new ArrayList<MOBAPlayer>();
        }

        public void AddPlayerToSession(MOBAPlayer player) 
        {
            if(player != null)
            {
                totalPlayerList.add(player);
            }
        }
    }
}