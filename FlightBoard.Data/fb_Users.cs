// Decompiled with JetBrains decompiler
// Type: FlightBoard.Data.fb_Users
// Assembly: FlightBoard.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 434D1468-4C4B-4EB7-A6F9-D9D136C51224
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Data.dll

using System;
using System.Collections.Generic;

namespace FlightBoard.Data
{
    public class fb_Users
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string SSN { get; set; }

        public int RoleId { get; set; }

        public string Password { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsActive { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_ItemsStatus> fb_ItemsStatus { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_ItemsStatus> fb_ItemsStatus1 { get; set; }

        public virtual fb_Roles fb_Roles { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_TeamMembers> fb_TeamMembers { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_Teams> fb_Teams { get; set; }

        public fb_Users()
        {
            this.fb_ItemsStatus = (ICollection<FlightBoard.Data.fb_ItemsStatus>)new HashSet<FlightBoard.Data.fb_ItemsStatus>();
            this.fb_ItemsStatus1 = (ICollection<FlightBoard.Data.fb_ItemsStatus>)new HashSet<FlightBoard.Data.fb_ItemsStatus>();
            this.fb_TeamMembers = (ICollection<FlightBoard.Data.fb_TeamMembers>)new HashSet<FlightBoard.Data.fb_TeamMembers>();
            this.fb_Teams = (ICollection<FlightBoard.Data.fb_Teams>)new HashSet<FlightBoard.Data.fb_Teams>();
        }
    }
}
