namespace MOBA_Manager
{
    public class PlaySession
    {
        private ArrayList<MOBAPlayer>  totalPlayerList;
        private ArrayList<Team> totalTeamList;

        public PlaySession() 
        {
            totalPlayerList = new ArrayList<MOBAPlayer>();
            totalTeamList = new ArrayList<Team>();
        }

        public void AddPlayerToSession(MOBAPlayer player) 
        {
            if(player != null)
            {
                totalPlayerList.add(player);
            }
        }

        public ArrayList<MOBAPlayer> GetPlayerList() 
        {
            return totalPlayerList;
        }

        public void AddTeamToSession(Team team) 
        {
            if(team != null) 
            {
                totalTeamList.add(team);
            }                          
        }

        public ArrayList<Team> GetTeamList() 
        {
            return totalTeamList;
        }

    }
}