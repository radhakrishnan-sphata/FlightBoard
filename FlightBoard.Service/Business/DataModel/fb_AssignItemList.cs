namespace FlightBoard.Service.Business.DataModels
{
    public class fb_AssignItemList
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int EventId { get; set; }

        public string ItemName { get; set; }

        public string Contract { get; set; }

        public string ProductionDate { get; set; }

        public string TeamMembers { get; set; }
    }
}
