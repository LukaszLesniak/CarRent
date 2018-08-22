using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRent.Model
{
    public class RentDisposition
    {
        public int Id { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
