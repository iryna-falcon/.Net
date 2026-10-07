using lab_4.Interfaces;
using System;
using System.Windows;

namespace lab_4.ArtWork
{
    public class Sculpture : ArtWork, IInsurable
    {
        public string Material { get; set; }

        public Sculpture(string title, int creationYear, string author, double value, string material)
            : base(title, creationYear, author, value)
        {
            Material = material;
        }

        public int EstimateAge()
        {
            return DateTime.Now.Year - CreationYear;
        }

        public override string Evaluate()
        {
            Value += Value * 0.15;
            return $"Скульптуру '{Title}' оцінено. Нова вартість: {Value} грн.";
        }

        public override string Restore() => $"Очищення та реставрація скульптури '{Title}'.";

        public static double ValueAll(List<ArtWork> sculptures)
        {
            double sum = 0;
            foreach (var s in sculptures)
            {
                sum += s.Value;
            }
            return sum;
        }

        public double GetInsuranceCost() => Value * 0.07;
    }
}