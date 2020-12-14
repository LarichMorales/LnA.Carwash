using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnA.CarwashBooking.WIndows.Models
{
    public class Service
    {
        public Guid ServiceId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public Decimal Price { get; set; }   
    }
}
