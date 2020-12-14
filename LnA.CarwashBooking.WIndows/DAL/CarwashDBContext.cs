using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LnA.CarwashBooking.WIndows.DAL
{
    public class CarwashDBContext : DbContext
    {
        public CarwashDBContext() : base("myConnectionString")
        {
            Database.SetInitializer(new LnA.CarwashBooking.WIndows.DAL.DataInitializer());
        }
        public DbSet<Models.Booking> Bookings { get; set; }
        public DbSet<Models.Service> Services { get; set; }
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.BookedService> BookedServices { get; set; }
    }
}
    