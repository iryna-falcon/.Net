using lab_4.Interfaces;

namespace lab_4.ArtWork
{
    public abstract class ArtWork : IAppraisable, IRestorable
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

        public abstract string Evaluate();
        public abstract string Restore();
    }
}