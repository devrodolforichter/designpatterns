namespace Richter.DesignPatternFactory.FactoryMethod
{
    public class DefaultProduct : IProduct
    {
        public string ShipFrom()
        {
            return " entrega indisponível.";
        }
    }
}
