﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnA.CarwashBooking.WIndows.Models
{
   public class Booking
   {
        public Guid? BookingId { get; set; }
        public Guid? UserId { get; set; }       
        public DateTime Date { get; set; }
        public string PayAmount { get; set; }
   }
}