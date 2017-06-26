using System.Security.Principal;

namespace BusinessLogicLayer.Users
{
    public class Administrators:Users
    {
        public Administrators(string name) {
            Name = name;
        }

        public string LogEvent(string eventName) {
            return @"User " + Name +" " + eventName; 
        }
    }
}
