namespace Richter.DesignPatternFactory.AbstractFactory
{
    internal class OmeletFactory : IOmeletFactory
    {
        public ILunch Prepare()
        {
            return new Omelet();
        }
    }
}
