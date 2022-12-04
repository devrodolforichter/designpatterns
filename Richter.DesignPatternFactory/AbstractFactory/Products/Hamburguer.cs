namespace Richter.DesignPatternFactory.AbstractFactory
{
    internal class Hamburguer : ILunch
    {
        public string GetDescription()
        {
            return "Alface, Maionese, Pão, Haburguer e Bacon!";
        }
    }
}
