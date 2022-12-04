namespace Richter.DesignPatternFactory.FactoryMethodWithAbstractClass
{
    internal class Dog : IAnimal, ISpecificSound
    {
        public string Name => "Dog";
        public string Sounds => "Au au";
    }
}