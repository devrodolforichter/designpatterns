namespace Richter.DesignPatternFactory.FactoryMethodWithAbstractClass
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(AnimalType type);
    }
}
