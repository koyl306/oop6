using System;

namespace _6pr
{
    class Program
    {
        static void Main(string[] args)
        {
            JournalCollection collection = new JournalCollection();

            collection.Add(new Journal("журнал1", "журнал1", 95.50, 120, 8));
            collection.Add(new Journal("журнал2", "журнал2", 120.00, 80, 10));
            collection.Add(new Journal("журнал3", "журнал3", 110.75, 150, 9));
            collection.Add(new Journal("журнал4", "журнал4", 70.00, 60, 6));

            Console.WriteLine("Відсортовані за продажем(спадання):\n");

            foreach (var journal in collection)
                Console.WriteLine(journal);
        }
    }
}