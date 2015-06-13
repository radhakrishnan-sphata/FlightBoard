namespace FlightBoard.Web.Models
{
    public class BatchItemModel
    {
        public int ID { get; set; }

        public int BatchID { get; set; }

        public int ItemId { get; set; }

        public int EventID { get; set; }

        public bool IsSubItem { get; set; }
    }
}
