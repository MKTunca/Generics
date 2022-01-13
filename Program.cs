using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities1 = new List<string>();
            cities1.Add("İstanbul");
            cities1.Add("Ankara");
            cities1.Add("İzmir");
            cities1.Add("Bursa");
            cities1.Add("Adana");

            Console.WriteLine(cities1.Count);

            MyList<string> cities2 = new MyList<string>();
            cities2.Add("London");
            cities2.Add("Paris");
            cities2.Add("Madrid");
            cities2.Add("Berlin");

            Console.WriteLine(cities2.Count);

            Console.ReadLine();
        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _Temparray;

        public MyList()
        {
            _array =new T[0];
        }
      public void Add(T item)
        {
            _Temparray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _Temparray.Length; i++)
            {
                _array[i] = _Temparray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }
    }
}
