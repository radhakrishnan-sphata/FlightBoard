using System.Collections.Generic;

namespace FlightBoard.Web.Models
{
    public class AssignItemModel
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int EventId { get; set; }

        public List<FlightBoard.Web.Models.AssignItemsList> AssignItemsList { get; set; }
    }
}
