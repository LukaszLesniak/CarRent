
namespace CarRent.PublicModel
{
   public class ClientPub
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DriverLicense { get; set; }

        public string PublicClientsName
        {
            get { return FirstName + " " + LastName; }
        }
      
    }
}
