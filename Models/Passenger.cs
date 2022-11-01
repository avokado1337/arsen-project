using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
    }
}
