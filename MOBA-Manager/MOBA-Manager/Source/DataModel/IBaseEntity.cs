using System.Drawing;

namespace MOBA_Manager.DataModel
{
    internal interface IBaseEntity
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        Team Team { get; set; }
        Image iconIndex { get; set; }

        string FullName();
    }
}