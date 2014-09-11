using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class MediumClassBuilder : IBuilder
    {
        private Car car = new Car();

        public void BuildCar()
        {
            car.Model = "Medium Class Car";
            car.Add("Whells ");
            car.Add("Doors ");
            car.Add("Seats ");
            car.Add("Sunroof ");
            car.Add("Lightenings ");
            car.Add("Audio System ");
            car.Add("Display ");
        }

        public void PaintCar()
        {
            car.Color = "Red";
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
