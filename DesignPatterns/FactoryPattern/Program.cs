using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Autos;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "minicooper";

            AutoFactory factory = new AutoFactory();

            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();
            car.TurnOff();
        }
    }
}
