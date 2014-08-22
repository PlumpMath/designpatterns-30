using System;
using System.Collections.Generic;
using System.Reflection;
using AbstractFactoryPattern.Autos;
using AbstractFactoryPattern.Autos.BMW;

namespace AbstractFactoryPattern.Factory
{
    public class BMWFactory : IAutoFactory
    {
        public IAutomobile CreateSportsCar()
        {
            return new BMWM3();
        }

        public IAutomobile CreateLuxuryCar()
        {
            return new BMW740i(); 
        }

        public IAutomobile CreateEconomyCar()
        {
            return new BMW328i();
        }
    }
}
