using CarRent.Model;
using CarRent.PublicModel;
using System.Collections.Generic;
using System.Linq;


namespace CarRent.Service
{
    public class CarService
    {
        public List<CarPub> GetCars(string nameFilter = null, string brandFilter = null, string colourFilter = null)
        {
            using (var context = new CarRentContext())
            {
                var s = context.Cars.Where(x => 
                (string.IsNullOrEmpty(nameFilter) || x.Name == nameFilter) 
                && (string.IsNullOrEmpty(brandFilter) || x.Brand == brandFilter) 
                && (string.IsNullOrEmpty(colourFilter) || x.Colour == colourFilter)).ToList().Select(x => CarMapper.ToPublicModel(x)).ToList();
                return s;
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
