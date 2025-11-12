using System;

namespace _6pr
{
    class Journal
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        public Journal(string name, string publisher, double price, int pages, int rating)
        {
            Name = name;
            Publisher = publisher;
            Price = price;
            Pages = pages;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Name} ({Publisher}) - Ціна: {Price:C}, Сторінок: {Pages}, Рейтинг: {Rating}/10";
        }
    }

    class JournalCollection : IEnumerable<Journal>
    {
        private List<Journal> journals = new List<Journal>();

        public void Add(Journal journal)
        {
            journals.Add(journal);
        }

        public IEnumerator<Journal> GetEnumerator()
        {
            journals.Sort((a, b) => b.Rating.CompareTo(a.Rating));
            foreach (var journal in journals)
                yield return journal;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}