using System;
using System.Windows;

namespace lab_3
{
    public class Painting : ArtWork
    {
        public string Technique { get; set; }

        public Painting(string title, int creationYear, string author, double value, string technique)
            : base(title, creationYear, author, value)
        {
            Technique = technique;
        }

        public string GetCanvasSize()
        {
            return "Стандартний розмір: 60x90 см";
        }

        public override void Evaluate()
        {
            Value += Value * 0.10;
            MessageBox.Show($"Картину '{Title}' (Техніка: {Technique}) оцінено. Нова вартість: {Value} грн.");
        }

        public override void Restore()
        {
            MessageBox.Show($"Проводиться реставрація полотна '{Title}'.");
        }
    }
}