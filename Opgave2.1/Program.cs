using System;
using System.Collections.Generic;

namespace Opgave2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>();
            ages.Add(13);
            ages.Add(14);
            ages.Add(13);
            ages.Add(15);
            ages.Add(13);
            ages.Add(14);
            ages.Add(14);
            ages.Add(15);
            ages.Remove(13);
            ages.Remove(15);
            ages.RemoveAt(2);
            foreach(int age in ages)
            {
                Console.WriteLine(age);
            }
            Console.ReadLine();
        }
    }
}
