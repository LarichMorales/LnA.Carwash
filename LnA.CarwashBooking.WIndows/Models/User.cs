using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LnA.CarwashBooking.WIndows.Models.Enums;

namespace LnA.CarwashBooking.WIndows.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public Role Role { get; set; }
    }
}
