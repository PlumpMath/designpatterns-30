using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Autos;
using FactoryMethodPattern.Factories;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main()
        {
            //IAutoFactory autoFactory = new BMWFactory();

            IAutoFactory autoFactory = LoadFactory();

            IAuto car = autoFactory.CreateAutomobile();

            car.TurnOn();
            car.TurnOff();
        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
