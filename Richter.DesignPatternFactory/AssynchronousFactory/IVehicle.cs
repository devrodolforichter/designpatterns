namespace Richter.DesignPatternFactory.AssynchronousFactory
{
    public interface IVehicle<T>
    {
        Task<T> InitAsync();
    }
}
