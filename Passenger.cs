namespace AirlineAPI.Models
{
    public class Passenger
    {
        public int Id { get; set; }

        
        public string FullName { get; set; }
        public string Email { get; set; }

    
        public Passenger(string fullName, string email)
        {
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));  
            Email = email ?? throw new ArgumentNullException(nameof(email));  
        }
    }
}
