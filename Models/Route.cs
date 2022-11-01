namespace Flight_booking.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string DepartureCity { get; set; }
        public string DepartureAirport { get; set; }
        public string DesitnationCity { get; set; }
        public string DestinationAirport { get; set; }
        public int AverageFlightTime { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
