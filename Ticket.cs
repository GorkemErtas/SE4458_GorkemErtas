namespace AirlineAPI.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public string PassengerName { get; set; }
        public bool IsCheckedIn { get; set; }

        // Yapıcı metod (constructor) ekleyin
        public Ticket(int flightId, string passengerName, bool isCheckedIn)
        {
            FlightId = flightId;
            PassengerName = passengerName;
            IsCheckedIn = isCheckedIn;
        }
    }
}
