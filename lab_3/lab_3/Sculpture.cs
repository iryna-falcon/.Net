using System;
using System.Windows;

namespace lab_3
{
    public class Sculpture : ArtWork
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

        public override void Evaluate()
        {
            Value += Value * 0.15;
            MessageBox.Show($"Скульптуру '{Title}' (Матеріал: {Material}) оцінено. Нова вартість: {Value} грн.");
        }

        public override void Restore()
        {
            MessageBox.Show($"Проводиться очищення та реставрація скульптури '{Title}'.");
        }
    }
}