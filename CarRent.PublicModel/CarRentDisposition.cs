using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.PublicModel
{
    public class CarRentDisposition
    {
        public CarRentDisposition()
        {
            this.Car = new CarPub();
            this.Client = new ClientPub();
        }
        public CarPub Car { get; set; }

        public ClientPub Client { get; set; }
    }
}
