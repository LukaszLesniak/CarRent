namespace BuissnesLayer.Model
{
    public class Client
    {
        private string nameValue;

        public string Name
        {
            get { return nameValue; }
            set { nameValue = value; }

        }

        private string lastNameValue;

        public string LastName
        {
            get { return lastNameValue; }
            set { lastNameValue = value; }

        }

        private string driverLicenseValue;

        public string DriverLicense
        {
            get { return driverLicenseValue; }
            set { driverLicenseValue = value; }

        }
        //public List<ClientPub> ClientList = new List<ClientPub>();
    }
}
