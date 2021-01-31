using System.Windows.Media.Imaging;

namespace MOBA_Manager.DataModel
{
    public class BaseEntity
    {
        protected string firstName;
        protected string middleName;
        protected string lastName;
        protected int age;
        protected Team team;
        private BitmapImage iconIndex;

        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public Team Team { get => team; set => team = value; }
        public BitmapImage IconIndex { get => iconIndex; set => iconIndex = value; }

        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }

        public void SetFullName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}