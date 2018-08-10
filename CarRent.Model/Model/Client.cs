using System.ComponentModel.DataAnnotations;

namespace CarRent.Model
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string DriverLicense { get; set; }
    }
}
