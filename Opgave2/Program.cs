using System;
using System.Collections.Generic;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Hans");
            names.Add("Gerda");
            names.Add("Knud");
            names.Add("Anders");
            names.Add("Johanne");
            names.Add("Karsten");
            names.Add("Irene");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            
        }
    }
}
