namespace FactoryMethodPattern.Autos
{
    public interface IAuto
    {
        string Name { get; }
        void SetName(string name);
        void TurnOn();
        void TurnOff();
    }
}