using System.Collections;

namespace Ovning5_Garage1._0
{
    public class Garage<T>(int capacity) : IGarage<T>, IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles = new T[capacity];
        private int capacity = capacity;
        public int Capacity { get { return capacity; } }

        int IGarage<T>.Capacity => Capacity;

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T v in vehicles)
            {
                if (v != null)
                    yield return v;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Park(T vehicle)
        {
            var index = Array.IndexOf(vehicles, null);
            if (index != -1)
                vehicles[index] = vehicle;
        }
        public void UnPark(T found)
        {
            var index = Array.IndexOf(vehicles, found);
            if (index != -1)
                vehicles[index] = null;
        }
    }
}
