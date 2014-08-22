using FactoryMethodPattern.Autos;

namespace FactoryMethodPattern.Factories
{
    class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new BMW("BMW M5 Cabriolet");
        }
    }
}