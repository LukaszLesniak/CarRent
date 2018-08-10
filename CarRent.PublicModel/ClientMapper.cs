
namespace CarRent.PublicModel
{
    public class ClientMapper
    {
        public static ClientPub ToPublicModel(Model.Client client)
        {
            return new ClientPub()
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                DriverLicense = client.DriverLicense
            };
        }
    }
}
