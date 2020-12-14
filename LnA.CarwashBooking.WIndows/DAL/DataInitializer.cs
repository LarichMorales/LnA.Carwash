using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace LnA.CarwashBooking.WIndows.DAL
{
   public class DataInitializer : DropCreateDatabaseAlways<CarwashDBContext>
    {
        protected override void Seed(CarwashDBContext context)
        {
            context.Users.Add(new Models.User()
            {
                UserId = Guid.NewGuid(),
                ContactNumber = "09094281257",
                Email = "admin",
                FirstName = "ADMIN",
                LastName = "ADMIN",
                Gender = Models.Enums.Gender.Male,
                Password = "admin",
                Role = Models.Enums.Role.Customer


            });
            context.Services.Add(new Models.Service()
            {
                Name = "LNA Wash",
                Desc = "Clean and Pristine",
                Price = 300,
                ServiceId = Guid.NewGuid()        
            });
            context.Services.Add(new Models.Service()
            {
                Name = "LNA Waterless",
                Desc = "Hydrophobic and Shiny",
                Price = 450,
                ServiceId = Guid.NewGuid()
            });
            context.Services.Add(new Models.Service()
            {
                Name = "LNA Shine",
                Desc = "Hydrophobic & Blooming",
                Price = 700,
                ServiceId = Guid.NewGuid()
            });
            context.Services.Add(new Models.Service()
            {
                Name = "LNA Signature",
                Desc = "Hydrophic, Blooming, Durable & Bacteria Free Interior",
                Price = 1500,
                ServiceId = Guid.NewGuid()
            });
            context.Services.Add(new Models.Service()
            {
                Name = "LNA Buff and Shine",
                Desc = "Defined Polish, Hydrophobic & Blooming",
                Price = 1500,
                ServiceId = Guid.NewGuid()
            });
        }
    }
}
