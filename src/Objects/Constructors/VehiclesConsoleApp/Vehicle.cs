using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santander.Vehicles.Model
{

    class Vehicle
    {
        public Make Make;
        public string Model;
        public int ProductionYear;
        public int Mileage;
        public string VIN;
        public byte MaxSpeed;
        public string Color;

        public decimal Price;

        public Person Owner;

        public void Sell(Person newOwner)
        {
            this.Owner = newOwner;
        }
    }
}
