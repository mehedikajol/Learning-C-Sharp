using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Storage<T>
    {
        private T[] _items;

        public Storage(int size)
        {
            _items = new T[size];
        }

        public void PutItem(int index, T value)
        {
            _items[index] = value;
        }

        public void ShowItems()
        {
            foreach (var item in _items)
                Console.Write(item + " ");
            Console.WriteLine();
        }

    }
}
