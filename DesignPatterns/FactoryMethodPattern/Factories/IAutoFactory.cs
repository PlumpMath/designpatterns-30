
using FactoryMethodPattern.Autos;

namespace FactoryMethodPattern.Factories
{
    public interface IAutoFactory
    {
        IAuto CreateAutomobile();
    }

}