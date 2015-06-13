
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FlightBoard.Web.Models
{
    public class DashboardModel
    {
        public IEnumerable<UserModel> Events;
        public IEnumerable<ProductionDatesModel> ProductionDates;

        public int EventId { get; set; }

        public string Contract { get; set; }

        public string EventName { get; set; }

        public DateTime? EventDate { get; set; }

        public int NoofItems { get; set; }

        public string TeamLead { get; set; }

        public int? UnitId { get; set; }

        public string UnitName { get; set; }

        public string Description { get; set; }

        public string MealName { get; set; }

        public string ProdDate { get; set; }

        public Decimal? Quantity { get; set; }

        public DateTime? RefreshTime { get; set; }

        public int ItemEvent_intid { get; set; }

        [ScaffoldColumn(false)]
        public IEnumerable<SelectListItem> EventsList
        {
            get
            {
                return (IEnumerable<SelectListItem>)new SelectList((IEnumerable)this.Events, "Contract", "EventName", (object)this.Contract);
            }
        }

        public List<DashboardModel.FirtModel> firstModel { get; set; }

        public List<DashboardModel.SecondModel> secondModel { get; set; }

        public List<ProductionDatesModel> productionDateModel { get; set; }

        public class FirtModel
        {
            public string Yield { get; set; }

            public string Portions { get; set; }

            public string PrepTime { get; set; }

            public string CookingTime { get; set; }

            public string CookingTemp { get; set; }

            public string PrepTemp { get; set; }

            public string itemName { get; set; }

            public string ProdDate { get; set; }

            public string ProdShift { get; set; }

            public int AssemblageID { get; set; }

            public int Prodrecipe_intid { get; set; }
        }

        public class SecondModel
        {
            public string IngriedentsName { get; set; }

            public string IngedientSize { get; set; }

            public string Note { get; set; }

            public int ComponentID { get; set; }

            public int subitemCount { get; set; }

            public int AssemblageID { get; set; }

            public int Prodrecipe_intid { get; set; }
        }

        public class ThirdMode
        {
            public string EventId { get; set; }

            public string ItemId { get; set; }

            public Decimal Quantity { get; set; }

            public int AssemblageID { get; set; }
        }
    }
}
