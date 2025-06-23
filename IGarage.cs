namespace Ovning5_Garage1._0
{
    public interface IGarage<T> : IEnumerable<T>
    {
        int Capacity { get; }
        void UnPark(T found);
        void Park(T vehicle);
    }
}
