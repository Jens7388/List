using System;
using System.Collections.Generic;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                List<int> ages = new List<int>();
                ages.Add(5);
                ages.Add(17);
                ages.Add(20);
                ages.Add(40);
                ages.Add(91);

                List<string> names = new List<string>();
                names.Add("Jens");
                names.Add("Mathias");
                names.Add("Christian");
                names.Add("Semko");
                names.Add("Nikolaj");
                names.Add("Marc");

                List<double> percentages = new List<double>() { 0.75, 0.23, 0.66, 0.17 };

                List<bool> areMarried = new List<bool>() { true, false, false, true, true };
                Console.WriteLine("Hvilken liste ønsker du at se?");
                Console.WriteLine("1. int liste");
                Console.WriteLine("2. string liste");
                Console.WriteLine("3. double liste");
                Console.WriteLine("4. bool liste\n");
                string input = Console.ReadLine();

                if(input == "1")
                {
                    foreach(int age in ages)
                    {
                        Console.WriteLine(age);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(input == "2")
                {
                    foreach(string name in names)
                    {
                        Console.WriteLine(name);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(input == "3")
                {
                    foreach(double percentage in percentages)
                    {
                        Console.WriteLine(percentage);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(input == "4")
                {
                    foreach(bool isMarried in areMarried)
                    {
                        Console.WriteLine(isMarried);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Ugyldigt input");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while(true);
        }
    }
}
