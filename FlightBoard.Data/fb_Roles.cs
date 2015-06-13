using System.Collections.Generic;

namespace FlightBoard.Data
{
    public class fb_Roles
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_Users> fb_Users { get; set; }

        public fb_Roles()
        {
            this.fb_Users = (ICollection<FlightBoard.Data.fb_Users>)new HashSet<FlightBoard.Data.fb_Users>();
        }
    }
}