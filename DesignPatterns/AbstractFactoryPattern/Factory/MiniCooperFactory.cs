using System;
using AbstractFactoryPattern.Autos;
using AbstractFactoryPattern.Autos.Mini;

namespace AbstractFactoryPattern.Factory
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAutomobile CreateSportsCar()
        {
            var mini = new MiniCooper();

            mini.AddSportPackage();

            return mini;
        }

        public IAutomobile CreateLuxuryCar()
        {
            var mini = new MiniCooper();
            
            mini.AddLuxuryPackage();
            
            return mini;
        }

        public IAutomobile CreateEconomyCar()
        {
            return new MiniCooper();       
        }
    }
}
