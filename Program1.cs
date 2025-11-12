using System;

namespace _6pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal[] journals =
            {
                new Journal("журнал1", "журнал1", 95.50),
                new Journal("журнал2", "журнал2", 120.00),
                new Journal("журнал3", "журнал3", 110.75),
                new Journal("журнал4", "журнал4", 70.00)
            };

            Console.WriteLine("Невідсортовано:\n");
            foreach (var j in journals)
                Console.WriteLine(j);
                
            Array.Sort(journals);

            Console.WriteLine("\nВідсортовано:\n");
            foreach (var j in journals)
                Console.WriteLine(j);
        }
    }
}