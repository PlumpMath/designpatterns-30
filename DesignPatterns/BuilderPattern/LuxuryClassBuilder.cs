using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class LuxuryClassBuilder : IBuilder
    {
        private Car car = new Car();

        public void BuildCar()
        {
            car.Model = "Luxury Class Car";
            car.Add("Whells ");
            car.Add("Doors ");
            car.Add("Seats ");
            car.Add("Sunroof ");
            car.Add("Lightenings ");
            car.Add("Audio System ");
            car.Add("Display ");
            car.Add("ABS/ESP ");
            car.Add("Airbags ");
            car.Add("Anti Theft System ");
        }

        public void PaintCar()
        {
            car.Color = "Black";
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
