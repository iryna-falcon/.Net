using lab_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4.ArtWork
{
    public class Photography : ArtWork, IInsurable
    {
        public string CameraModel { get; set; }

        public Photography(string title, int creationYear, string author, double value, string cameraModel)
            : base(title, creationYear, author, value) { CameraModel = cameraModel; }

        public override string Evaluate()
        {
            Value += Value * 0.05;
            return $"Фотографію '{Title}' оцінено. Нова вартість: {Value} грн.";
        }

        public override string Restore() => $"Цифрове відновлення фотографії '{Title}'.";

        public double GetInsuranceCost() => Value * 0.03;
    }
}
