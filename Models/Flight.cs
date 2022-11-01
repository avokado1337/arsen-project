using System;

namespace Flight_booking.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public DateTime FlightStartDate { get; set; }
        public DateTime FlightEndDate { get; set; }
        public string Status { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
    }
}
