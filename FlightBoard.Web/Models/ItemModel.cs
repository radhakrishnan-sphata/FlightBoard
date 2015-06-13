// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.ItemModel
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FlightBoard.Web.Models
{
    public class ItemModel
    {
        [HiddenInput]
        public int ItemId { get; set; }

        [ScaffoldColumn(true)]
        [Display(Name = "Item Name")]
        [Required(ErrorMessage = "Item name is mandatory.")]
        public string ItemName { get; set; }

        [ScaffoldColumn(true)]
        [Display(Name = "Team Member")]
        [Required(ErrorMessage = "Team name is mandatory.")]
        public string TeamMember { get; set; }

        [Display(Name = "Team Name")]
        [ScaffoldColumn(true)]
        [Required(ErrorMessage = "Team name is mandatory.")]
        public string ReceipeDetail { get; set; }

        public string Image { get; set; }

        public string ProductionFrom { get; set; }

        public string ProductionTo { get; set; }

        [HiddenInput]
        public int EventId { get; set; }

        [ScaffoldColumn(true)]
        [Display(Name = "Event Name")]
        [Required(ErrorMessage = "Event name is mandatory.")]
        public string EventName { get; set; }

        public List<CheckItem> ItemList { get; set; }

        public List<KeyValuePair<int, string>> Teamlist { get; set; }

        public int ItemEvent_intid { get; set; }

        public Decimal? Quantity { get; set; }

        public int ID { get; set; }

        public string Contract { get; set; }

        public bool IsSubItem { get; set; }

        public string UniQueItemIds { get; set; }

        public string EventDate { get; set; }

        public string EventEndDate { get; set; }

        public bool HasSubItem { get; set; }

        public int? PrepAreaId { get; set; }

        public string PrepAreaName { get; set; }

        public string ItemImageFileName { get; set; }

        public List<FlightBoard.Web.Models.SubItemsList> SubItemsList { get; set; }

        public string EventIds { get; set; }

        public List<string> ProductionDates { get; set; }

        public List<FlightBoard.Web.Models.TeamMember> TeamMemberList { get; set; }

        public List<fb_Items_View> AssignedItemsList { get; set; }

        public List<FlightBoard.Web.Models.EditItemList> EditItemList { get; set; }

        public bool IsEdit { get; set; }

        public string Notes { get; set; }

        public bool IsBack { get; set; }
    }
}
