using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace FlightBoard.Web.Models
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<ProductionDatesModel> ProductionDateModels { get; set; }

    public ApplicationDbContext()
    {
      //this.Config("DefaultConnection");
    }
  }
}