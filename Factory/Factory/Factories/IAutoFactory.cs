using Factory.Autos;

namespace Factory.Factories
{
    public interface IAutoFactory
    {
        IAuto CreateAutomobile(); 
    }
}
