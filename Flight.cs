namespace AirlineAPI.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }

        
        public Flight(string from, string to, DateTime date, int capacity)
        {
            From = from;
            To = to;
            Date = date;
            Capacity = capacity;
        }
    }
}
