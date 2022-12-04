namespace Richter.DesignPatternFactory.AbstractFactory
{
    internal class HamburguerFactory : IHamburguerFactory
    {
        public ILunch Prepare()
        {
            return new Hamburguer();
        }
    }
}
