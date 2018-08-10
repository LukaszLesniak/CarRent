using CarRent.Model;
using CarRent.PublicModel;
using System.Collections.Generic;
using System.Linq;

namespace CarRent.Service
{
    public class ClientService
    {
        public List<PublicModel.ClientPub> GetClients()
        {
            using (var context = new Model.CarRentContext())
            {
                return context.Clients.Select(x=> ClientMapper.ToPublicModel(x)).ToList();
            }
        }

        public string CreateCar(CarPub carToCreate)
        {
            using (var context = new CarRentContext())
            {
                context.Cars.Add(new Model.Car()
                {
                    Brand = carToCreate.Brand,
                    Colour = carToCreate.Colour,
                    Name = carToCreate.CarName,
                    Price = carToCreate.Price
                });
                context.SaveChanges();
            }

            return "Success";
        }

    }
}
