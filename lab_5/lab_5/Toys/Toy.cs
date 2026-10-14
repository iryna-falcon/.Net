namespace lab_5.Toys
{
    public class Toy : IComparable<Toy>
    {
        private string _title;
        private decimal _cost;
        private int _minAge;
        private int _maxAge;

        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Назва іграшки не може бути порожньою.", nameof(Title));
                }
                _title = value;
            }
        }

        public decimal Cost
        {
            get => _cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Вартість не може бути від'ємною.", nameof(Cost));
                }
                _cost = value;
            }
        }

        public int MinAge
        {
            get => _minAge;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Мінімальний вік не може бути менше 0.", nameof(MinAge));
                }
                _minAge = value;
            }
        }

        public int MaxAge
        {
            get => _maxAge;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Максимальний вік не може бути менше 0.", nameof(MaxAge));
                }
                _maxAge = value;
            }
        }

        public Toy(string title, decimal cost, int minAge, int maxAge)
        {
            Title = title;
            Cost = cost;
            MinAge = minAge;
            MaxAge = maxAge;
            if (minAge > maxAge)
            {
                throw new ArgumentException("Мінімальний вік не може перевищувати максимальний.");
            }
        }

        public int CompareTo(Toy? other)
        {
            if (other == null) return 1;
            return this.Cost.CompareTo(other.Cost);
        }

        public override string ToString()
        {
            return $"Назва: {Title}, Вартість: {Cost} грн, Вік: від {MinAge} до {MaxAge} років";
        }
    }
}
