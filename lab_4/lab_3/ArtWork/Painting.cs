using lab_4.Interfaces;
using System;
using System.Windows;

namespace lab_4.ArtWork
{
    public class Painting : ArtWork, IInsurable
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

        public override string Evaluate()
        {
            Value += Value * 0.10;
            return $"Картину '{Title}' оцінено. Нова вартість: {Value} грн.";
        }

        public override string Restore() => $"Проводиться реставрація полотна '{Title}'.";

        public double GetInsuranceCost() => Value * 0.05;
    }
}