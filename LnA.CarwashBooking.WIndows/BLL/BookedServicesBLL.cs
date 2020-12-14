using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LnA.CarwashBooking.WIndows.DAL;
using LnA.CarwashBooking.WIndows.BLL;
using LnA.CarwashBooking.WIndows.Helpers;
using LnA.CarwashBooking.WIndows.Models;

namespace LnA.CarwashBooking.WIndows.BLL
{
    public static class BookedServicesBLL
    {
        private static CarwashDBContext db = new CarwashDBContext();

        public static Operation Add(BookedService bServices)
        {
            try
            {
                db.BookedServices.Add(bServices);
                db.SaveChanges();

                return new Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = bServices.bsID
                };
            }
            catch (Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }
    }
}
