// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.fb_Items_View
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using Lib.Web.Mvc.JQuery.JqGrid.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FlightBoard.Web.Models
{
    public class fb_Items_View
    {
        [ScaffoldColumn(false)]
        [Key]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true)]
        public int ID { get; set; }

        [JqGridColumnSortable(true)]
        [JqGridColumnFormatter("ShowSubitemsInBold")]
        [Display(Name = "Item Name")]
        [JqGridColumnLayout]
        [JqGridColumnSearchable(false)]
        public string ItemName { get; set; }

        [JqGridColumnLayout]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true)]
        [Display(Name = "Contract#")]
        public string ContractID { get; set; }

        [JqGridColumnLayout]
        [Display(Name = "Event Date")]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true)]
        public string EventDate { get; set; }

        [JqGridColumnSearchable(false)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [JqGridColumnFormatter("ShowProduction")]
        [JqGridColumnSortable(false)]
        [Display(Name = "Production Date")]
        [JqGridColumnLayout]
        public string ProductionFrom { get; set; }

        [Display(Name = "Batched")]
        [JqGridColumnLayout]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true)]
        [JqGridColumnFormatter("ShowBtachIcon")]
        public string BatchName { get; set; }

        [HiddenInput]
        public string TeamLead { get; set; }

        [Display(Name = "Teams")]
        [JqGridColumnSortable(false)]
        [JqGridColumnLayout]
        [JqGridColumnSearchable(false)]
        public string TeamMember
        {
            get
            {
                if (string.IsNullOrEmpty(this.TeamLead))
                    return "";
                return "<a title='Team Member Details' class='edit-user' href='#' onclick='TeamMember(" + (object)this.ItemId + ", " + (string)(object)this.EventID + ")'><span class='icon teamMember'></span></a>";
            }
        }

        [JqGridColumnSortable(false)]
        [JqGridColumnLayout]
        [JqGridColumnSearchable(false)]
        public string Recipe
        {
            get
            {
                return "<a title='Recipe Details' class='edit-user' href='#' onclick='GetRecipeDetails(" + (object)this.EventID + ", " + (string)(object)this.ItemId + "," + (string)(object)this.Quantity + "," + (string)(object)this.ItemId + ")'><span class='icon recipe'></span></a>";
            }
        }

        [HiddenInput]
        public bool IsSubItem { get; set; }

        [HiddenInput]
        public int EventID { get; set; }

        [HiddenInput]
        public Decimal? Quantity { get; set; }

        [HiddenInput]
        public int ItemId { get; set; }

        [JqGridColumnLayout]
        [JqGridColumnSortable(false)]
        [JqGridColumnSearchable(false)]
        public string Notes
        {
            get
            {
                return "<a title='Notes' class='edit-user' href='#' onclick='ShowNotes(" + (object)this.ItemId + "," + (string)(object)this.EventID + ")'><span class='icon notes'></span></a>";
            }
        }
    }
}
