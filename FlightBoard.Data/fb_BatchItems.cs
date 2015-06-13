namespace FlightBoard.Data
{
    public class fb_BatchItems
    {
        public int ID { get; set; }

        public int BatchID { get; set; }

        public int ItemID { get; set; }

        public int EventID { get; set; }

        public bool IsSubItem { get; set; }

        public virtual fb_Batches fb_Batches { get; set; }
    }
}
