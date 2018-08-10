using System.Data.Entity;

namespace CarRent.Model
{
    public class CarRentContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }

        public CarRentContext() : base("Data Source=DESKTOP-E77O8UU;Database=CarRent;Integrated Security=True;")
        {

        }

    }
}
