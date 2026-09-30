using System;

namespace lab_3
{
    public abstract class ArtWork
    {
        public string Title { get; set; }
        public int CreationYear { get; set; }
        public string Author { get; set; }
        public double Value { get; set; }

        public ArtWork(string title, int creationYear, string author, double value)
        {
            if (value < 0)
                throw new ArgumentException("Вартість не може бути від'ємною.");

            Title = title;
            CreationYear = creationYear;
            Author = author;
            Value = value;
        }

        public virtual void Evaluate() { }
        public virtual void Restore() { }
    }
}