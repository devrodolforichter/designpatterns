namespace Richter.DesignPatternFactory.AbstractFactory
{
    internal interface IOmeletFactory : IFactoryLunch
    {
        ILunch Prepare();
    }
}