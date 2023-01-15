namespace GenericTest
{
    public class EventList<T> : List<T>
    {
        public event Action<T> Added;
        public event Action<T> Removed;

        public new void Add(T item)
        {
            base.Add(item);
            Added?.Invoke(item);
        }

        public new void Remove(T item)
        {
            base.Remove(item);
            Removed?.Invoke(item);
        }
    }

    class EventListTest
    {
        public static void Run()
        {
            Console.WriteLine("\n\nEventListTest testing...");

            EventList<string> names = new EventList<string>();
            names.Added += OnAdded;
            names.Removed += OnRemoved;

            names.Add("tarik");
            names.Add("ali");
            names.Add("fatma");

            names.Remove("tarik");
        }

        private static void OnAdded(string obj)
        {
            Console.WriteLine($"Added item: {obj}");
        }

        private static void OnRemoved(string obj)
        {
            Console.WriteLine($"Removed item: {obj}");
        }
    }
}