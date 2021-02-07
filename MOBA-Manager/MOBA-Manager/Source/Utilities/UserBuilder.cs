using MOBA_Manager.DataModel;

namespace MOBA_Manager.Game
{
    internal static class UserBuilder
    {
        //Singleton?
        private static User onlyUser = null;

        public static User CreateUser()
        {
            onlyUser = new User();
            return onlyUser;
        }

        public static User GetInstance()
        {
            return onlyUser;
        }

        public static User WithName(string firstName, string lastName)
        {
            onlyUser.SetFullName(firstName, lastName);
            return onlyUser;
        }

        public static User SetTeam(Team team)
        {
            onlyUser.Team = team;
            return onlyUser;
        }

        public static User WithTeam(Team team)
        {
            return SetTeam(team);
        }
    }
}