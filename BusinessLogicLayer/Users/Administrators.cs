using System.Security.Principal;

namespace BusinessLogicLayer.Users
{
    public class Administrators:Users
    {
        public Administrators(string name) {
            Name = name;
        }
    }
}
