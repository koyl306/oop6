using System;

namespace _6pr
{
    class Journal : IComparable<Journal>
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }

        public Journal(string name, string publisher, double price)
        {
            Name = name;
            Publisher = publisher;
            Price = price;
        }

        public int CompareTo(Journal other)
        {
            if (other == null) return 1;
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Name} ({Publisher}) - {Price:C}";
        }
    }
}