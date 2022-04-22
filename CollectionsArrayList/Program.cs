using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArrayList
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList names = new ArrayList();
            names.Add("Bangladesh");
            names.Add("Dhaka");
            names.Add("Mirpur - 1");
            names.Add(true);
            names.Add(23.4);

            foreach (var name in names)
                Console.WriteLine(name);
            Console.WriteLine(names.Count + "\n");

            names.RemoveAt(names.Count - 1);
            foreach (var name in names)
                Console.WriteLine(name);
            Console.WriteLine(names.Count + "\n");

            List<string> values = new List<string>();
            values.Add("lorem");
            values.Add("ipsum");
            values.Add("dolor");
            values.Add("sit");
            values.Add("amet");

            foreach (var value in values)
                Console.WriteLine(value);

        }
    }
}