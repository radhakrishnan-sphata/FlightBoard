
using System.Security.Principal;

namespace FlightBoard.Web.Models
{
    public class CustomIdentity : IIdentity
    {
        public string AuthenticationType
        {
            get
            {
                return "Custom";
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return !string.IsNullOrEmpty(this.Name);
            }
        }

        public string Name { get; private set; }

        public CustomIdentity(string name)
        {
            this.Name = name;
        }
    }
}
