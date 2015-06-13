namespace FlightBoard.Data
{
    public class ProcGetEventStatusByProductionDate_Result
    {
        public int? EventId { get; set; }

        public string ContractID { get; set; }

        public int? TotalItemCount { get; set; }

        public int? TotalCompletedItemsCount { get; set; }
    }
}