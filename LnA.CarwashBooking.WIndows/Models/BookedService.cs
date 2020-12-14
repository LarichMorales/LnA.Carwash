using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnA.CarwashBooking.WIndows.Models
{
    public class BookedService
    {
        
        [Key]public Guid? bsID { get; set; }
        public Guid BookingId { get; set; }
        public string serviceName { get; set; }
        public int serviceCount { get; set; }

    }
}
