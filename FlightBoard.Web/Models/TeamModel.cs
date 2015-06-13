// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.TeamModel
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using FlightBoard.Data;
using FlightBoard.Service.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Mvc;

namespace FlightBoard.Web.Models
{
    public class TeamModel
    {
        [HiddenInput]
        public int TeamId { get; set; }

        [Display(Name = "Team Name")]
        [Required(ErrorMessage = "Team name is mandatory.")]
        [ScaffoldColumn(true)]
        public string TeamName { get; set; }

        [Required(ErrorMessage = "Team LeadId is mandatory.")]
        [Display(Name = "Team LeadId")]
        [ScaffoldColumn(false)]
        public int TeamLeadId { get; set; }

        [Required(ErrorMessage = "Production From Date is mandatory.")]
        [ScaffoldColumn(false)]
        [Display(Name = "Production From Date")]
        public DateTime TeamStartDate { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Production To Date")]
        [Required(ErrorMessage = "Production To Date is mandatory.")]
        public DateTime TeamEndDate { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "IsActive")]
        [Required(ErrorMessage = "IsActive is mandatory.")]
        public bool IsActive { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        public int? CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Updated Date")]
        public DateTime? UpdatedDate { get; set; }

        [Display(Name = "Team Leader Name By")]
        [ScaffoldColumn(true)]
        public string TeamLeaderName { get; set; }

        [ScaffoldColumn(false)]
        public List<TeamMembersModel> fb_TeamMembers { get; set; }

        [ScaffoldColumn(false)]
        public virtual fb_Users fb_Users { get; set; }

        public SelectList TeamLeadList { get; set; }

        public List<int> TeammemberList { get; set; }

        [Display(Name = "Updated By")]
        [ScaffoldColumn(false)]
        public int? UpdatedBy { get; set; }

        public TeamModel()
        {
            ParameterExpression parameterExpression;
            // ISSUE: method reference
            //this.TeamLeadList = new SelectList((IEnumerable)Queryable.Where<fb_Users>(((BusinessServiceBase<fb_Users>)new UserService()).FindAll(), Expression.Lambda<Func<fb_Users, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Users.get_RoleId))), (Expression)Expression.Constant((object)2, typeof(int))), new ParameterExpression[1]
            //  {
            //    parameterExpression
            //  })), "UserId", "FirstName", (object)this.TeamLeadId);
        }
    }
}
