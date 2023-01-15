namespace GenericTest
{
    public class CustomList<T>
    {
        public int Count => _array.Length;
        public T this[int i] => _array[i];
        private T[] _array;
        
        public CustomList()
        {
            _array = new T[0];
        }

        public void Add(T t)
        {
            var tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
                _array[i] = tempArray[i];

            _array[_array.Length -1] = t;
        }

        public void Remove(T t)
        {
            int removeIndex = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (t.Equals(_array[i]))
                    removeIndex = i;
            }

            for (int i = removeIndex; i < _array.Length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }
            
            Array.Resize(ref _array, _array.Length - 1);
        }
    }
    
    class CustomListTest
    {
        public static void Run()
        {
            Console.WriteLine("\n\nCustomListTest testing...");
            
            CustomList<string> names = new CustomList<string>();
            names.Add("tarik");
            names.Add("ali");
            names.Add("veli");
            names.Add("ayse");
            names.Add("fatma");
            LogElements(names);
            
            names.Remove("tarik");
            LogElements(names);

            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(2);
            numbers.Add(6);
            LogElements(numbers);
        }

        private static void LogElements<T>(CustomList<T> list)
        {
            Console.WriteLine($"\nCount: {list.Count} =>");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i}. element: {list[i]}");
            }
        }
    }
}