// Decompiled with JetBrains decompiler
// Type: FlightBoard.Data.fb_Teams
// Assembly: FlightBoard.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 434D1468-4C4B-4EB7-A6F9-D9D136C51224
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Data.dll

using System;
using System.Collections.Generic;

namespace FlightBoard.Data
{
    public class fb_Teams
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; }

        public int TeamLeadId { get; set; }

        public DateTime TeamStartDate { get; set; }

        public DateTime TeamEndDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_ItemsStatus> fb_ItemsStatus { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_TeamMembers> fb_TeamMembers { get; set; }

        public virtual fb_Users fb_Users { get; set; }

        public fb_Teams()
        {
            this.fb_ItemsStatus = (ICollection<FlightBoard.Data.fb_ItemsStatus>)new HashSet<FlightBoard.Data.fb_ItemsStatus>();
            this.fb_TeamMembers = (ICollection<FlightBoard.Data.fb_TeamMembers>)new HashSet<FlightBoard.Data.fb_TeamMembers>();
        }
    }
}
