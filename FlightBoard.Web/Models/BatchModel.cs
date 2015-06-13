
using System.ComponentModel.DataAnnotations;

namespace FlightBoard.Web.Models
{
    public class BatchModel
    {
        public int ID { get; set; }

        [ScaffoldColumn(true)]
        [Display(Name = "Batch Name")]
        [Required(ErrorMessage = "Batch name is mandatory.")]
        public string Name { get; set; }

        public string Color { get; set; }
    }
}
