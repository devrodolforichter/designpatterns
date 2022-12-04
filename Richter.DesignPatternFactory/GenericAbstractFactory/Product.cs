namespace Richter.DesignPatternFactory.AbstractFactory
{
    public class Product
    {
        public IMonitor Monitor { get; set; }
        public IComputer Computer { get; set; }
    }
}
