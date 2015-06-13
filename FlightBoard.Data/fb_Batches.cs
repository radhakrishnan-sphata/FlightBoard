using System.Collections.Generic;

namespace FlightBoard.Data
{
    public class fb_Batches
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_BatchItems> fb_BatchItems { get; set; }

        public fb_Batches()
        {
            this.fb_BatchItems = (ICollection<FlightBoard.Data.fb_BatchItems>)new HashSet<FlightBoard.Data.fb_BatchItems>();
        }
    }
}
