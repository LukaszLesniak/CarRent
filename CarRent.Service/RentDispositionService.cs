using CarRent.Model;
using CarRent.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRent.Service
{
    public class RentDispositionService
    {
        public List<PublicModel.ClientPub> GetClients()
        {
            using (var context = new CarRentContext())
            {
                return context.Clients.Select(x=> ClientMapper.ToPublicModel(x)).ToList();
            }
        }

        public string CreateRentDispositon(CarRentDisposition dispositionToCreate)
        {
            using (var context = new CarRentContext())
            {
                int clientId;
                var existingClient = context.Clients.FirstOrDefault(x=> x.DriverLicense == dispositionToCreate.Client.DriverLicense);
                if (existingClient == null)
                {
                    var clientToCreate = new Client()
                    {
                        FirstName = dispositionToCreate.Client.FirstName,
                        LastName = dispositionToCreate.Client.LastName,
                        DriverLicense = dispositionToCreate.Client.DriverLicense

                    };

                    context.Clients.Add(clientToCreate);
                    context.SaveChanges();

                    clientId = clientToCreate.Id;
                }
                else
                {
                    clientId = existingClient.Id;
                }

                int carId;
                var existingCar = context.Cars.FirstOrDefault(x => x.Brand == dispositionToCreate.Car.Brand && x.Name == dispositionToCreate.Car.CarName && x.Colour == dispositionToCreate.Car.Colour
                    && x.Price == dispositionToCreate.Car.Price);

                if (existingCar == null)
                {
                    carId = 1;
                }
                else
                {
                    carId = existingCar.Id;
                }

                var rentDisposition = new RentDisposition()
                {
                    ClientId = clientId,
                    CarId = carId,
                    CreatedOn = DateTime.Now
                };

                context.RentDispostions.Add(rentDisposition);
                context.SaveChanges();

            }

            return "Success";
        }

    }
}
