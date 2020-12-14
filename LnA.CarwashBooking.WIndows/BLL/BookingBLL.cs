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
    public static class BookingBLL
    {
        private static CarwashDBContext db = new CarwashDBContext();

        public static Operation Add(Booking booking)
        {
            try
            {
                db.Bookings.Add(booking);
                db.SaveChanges();

                return new Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = booking.BookingId
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
