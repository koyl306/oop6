using System;

namespace _6pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal[] journals =
            {
                new Journal("журнал1", "журнал1", 95.50, 120, 8),
                new Journal("журнал2", "журнал2", 120.00, 80, 10),
                new Journal("журнал3", "журнал3", 110.75, 150, 9),
                new Journal("журнал4", "журнал4", 70.00, 60, 6)
            };

            Console.WriteLine("Невідсортовані:\n");
            foreach (var j in journals)
                Console.WriteLine(j);

            Array.Sort(journals);
            Console.WriteLine("\nСортовані за ціною:\n");
            foreach (var j in journals)
                Console.WriteLine(j);

            Array.Sort(journals, new JournalPagesComparer());
            Console.WriteLine("\nСортовані за сторінками:\n");
            foreach (var j in journals)
                Console.WriteLine(j);

            Array.Sort(journals, new JournalRatingComparer());
            Console.WriteLine("\nСортовані за продажем:\n");
            foreach (var j in journals)
                Console.WriteLine(j);
        }
    }
}