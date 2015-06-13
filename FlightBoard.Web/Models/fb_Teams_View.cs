// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.fb_Teams_View
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using FlightBoard.Web.Helpers;
using Lib.Web.Mvc.JQuery.JqGrid.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace FlightBoard.Web.Models
{
    public class fb_Teams_View
    {
        [JqGridColumnSortable(true)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        public int TeamId { get; set; }

        [JqGridColumnSortable(false)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [JqGridColumnSearchable(false)]
        [Display(Name = "Production From")]
        [JqGridColumnLayout]
        public DateTime TeamStartDate { get; set; }

        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(false)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Production To")]
        [JqGridColumnLayout]
        public DateTime TeamEndDate { get; set; }

        [JqGridColumnSortable(true)]
        [Display(Name = "Team Name")]
        [JqGridColumnLayout]
        [JqGridColumnSearchable(false)]
        public string TeamName { get; set; }

        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(false)]
        public int TeamLeadId { get; set; }

        [JqGridColumnSortable(false)]
        [JqGridColumnSearchable(false)]
        [Display(Name = "Team Lead Name")]
        [JqGridColumnLayout]
        public string TeamLeadName { get; set; }

        [JqGridColumnSearchable(false)]
        [Display(Name = "Team Member")]
        [JqGridColumnLayout]
        [JqGridColumnSortable(false)]
        public string TeamMember
        {
            get
            {
                return "<a title='Team Member Details' class='edit-user' href='#' onclick='TeamMember(" + (object)this.TeamId + ")'><span class='icon teamMember'></span></a>";
            }
        }

        [JqGridColumnLayout]
        [JqGridColumnSortable(false)]
        [JqGridColumnSearchable(false)]
        public string Actions
        {
            get
            {
                return string.Concat(new object[4]
        {
          (object) HtmlHelpers.GetEditLink(1, this.TeamId, "Edit Team", "../Team/Edit"),
          (object) " <a title='Delete Team' class='edit-user' href='#' onclick='deleteTeam(",
          (object) this.TeamId,
          (object) ")'><span class='icon-delete'></span></a>"
        });
            }
        }

        [ScaffoldColumn(false)]
        public string TeamMemberName { get; set; }

        [ScaffoldColumn(false)]
        public int TeamMemberId { get; set; }
    }
}
