using lab_4.ArtWork;
using lab_4.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace lab_4.Tests
{
    [TestClass]
    public class ArtAnalysisTests
    {
        [TestMethod]
        public void GetTotalValueBefore1900_MixedList_ReturnsCorrectSum()
        {
            var works = new List<lab_4.ArtWork.ArtWork>
            {
                new Painting("Мона Ліза", 1503, "Леонардо да Вінчі", 1000, "Олія"),
                new Sculpture("Хмарна брама", 2006, "Аніш Капур", 500, "Сталь"),
                new Painting("Зоряна ніч", 1889, "Вінсент ван Гог", 200, "Олія"),
                new Sculpture("Мислитель", 1904, "Огюст Роден", 300, "Бронза")
            };

            double expected = 1200;

            double actual = ArtAnalysis.GetTotalValueBefore1900(works);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalValueBefore1900_EmptyList_ReturnsZero()
        {
            var works = new List<lab_4.ArtWork.ArtWork>();
            double expected = 0;

            double actual = ArtAnalysis.GetTotalValueBefore1900(works);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalValueBefore1900_AllNewWorks_ReturnsZero()
        {
            var works = new List<lab_4.ArtWork.ArtWork>
            {
                new Painting("Крик", 1910, "Едвард Мунк", 800, "Олія"),
                new Sculpture("Мислитель", 1904, "Огюст Роден", 300, "Бронза")
            };
            double expected = 0;

            double actual = ArtAnalysis.GetTotalValueBefore1900(works);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValueSum_Sculpture()
        {
            var works = new List<lab_4.ArtWork.ArtWork>
            {
                new Sculpture("Хмарна брама", 2006, "Аніш Капур", 500, "Сталь"),
                new Sculpture("Мислитель", 1904, "Огюст Роден", 300, "Бронза")
            };

            double expected = 800;

            double actual = Sculpture.ValueAll(works);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalInsuranceCost_MixedInsurables_ReturnsCorrectSum()
        {
            var items = new List<IInsurable>
    {
        new Painting("Зоряна ніч", 1889, "Вінсент ван Гог", 1000, "Олія"),
        new Sculpture("Мислитель", 1904, "Огюст Роден", 2000, "Бронза"),
        new Photography("Обід на хмарочосі", 1932, "Чарльз Еббетс", 500, "Leica")
    };

            double expected = 205;

            double actual = ArtAnalysis.GetTotalInsuranceCost(items);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PhotographyEvaluate_IncreasesValueCorrectly()
        {
            var photo = new Photography("Світанок", 2020, "Джон Доу", 100, "Canon");

            string result = photo.Evaluate();

            Assert.AreEqual(105, photo.Value);
            StringAssert.Contains(result, "Нова вартість: 105");
        }
    }
}