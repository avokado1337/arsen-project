namespace Flight_booking.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Plane { get; set; }
        public int Seat { get; set; }
        public bool IsReserved { get; set; }
        public int Price { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }

    }
}
