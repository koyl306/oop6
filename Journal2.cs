using System;

namespace _6pr
{
    class Journal : IComparable<Journal>
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

        public int CompareTo(Journal other)
        {
            if (other == null) return 1;
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Name} ({Publisher}) - Ціна: {Price:C}, Сторінок: {Pages}, Рейтинг: {Rating}/10";
        }
    }

    class JournalPagesComparer : IComparer<Journal>
    {
        public int Compare(Journal x, Journal y)
        {
            if (x == null || y == null)
                throw new ArgumentException("err.null");
            return x.Pages.CompareTo(y.Pages);
        }
    }

    class JournalRatingComparer : IComparer<Journal>
    {
        public int Compare(Journal x, Journal y)
        {
            if (x == null || y == null)
                throw new ArgumentException("err.null");
            return x.Rating.CompareTo(y.Rating);
        }
    }
}