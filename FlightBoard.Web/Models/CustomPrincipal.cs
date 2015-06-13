using System.Security.Principal;

namespace FlightBoard.Web.Models
{
    public class CustomPrincipal : IPrincipal
    {
        public IIdentity Identity { get; private set; }

        public CustomPrincipal(CustomIdentity identity)
        {
            this.Identity = (IIdentity)identity;
        }

        public bool IsInRole(string role)
        {
            return true;
        }
    }
}