using MOBA_Manager.DataModel;
using System;

namespace MOBA_Manager.Game
{
    internal static class UserBuilder
    {
        //Singleton?
        private static User onlyUser = null;

        public static User CreateUser()
        {
            if (onlyUser == null)
            {
                onlyUser = new User();
                return onlyUser;
            }
            else
            {
                throw new Exception();
            }
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
            return onlyUser;
        }
    }
}