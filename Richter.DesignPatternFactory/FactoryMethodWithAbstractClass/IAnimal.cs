namespace Richter.DesignPatternFactory.FactoryMethodWithAbstractClass
{
    public interface IAnimal : ISpecificSound
    {
        string Name { get; }
    }
}