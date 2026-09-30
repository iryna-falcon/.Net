using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using lab_3;

namespace lab_3.Tests
{
    [TestClass]
    public class ArtAnalysisTests
    {
        [TestMethod]
        public void GetTotalValueBefore1900_MixedList_ReturnsCorrectSum()
        {
            var works = new List<ArtWork>
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
            var works = new List<ArtWork>();
            double expected = 0;

            double actual = ArtAnalysis.GetTotalValueBefore1900(works);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalValueBefore1900_AllNewWorks_ReturnsZero()
        {
            var works = new List<ArtWork>
            {
                new Painting("Крик", 1910, "Едвард Мунк", 800, "Олія"),
                new Sculpture("Мислитель", 1904, "Огюст Роден", 300, "Бронза")
            };
            double expected = 0;

            double actual = ArtAnalysis.GetTotalValueBefore1900(works);

            Assert.AreEqual(expected, actual);
        }
    }
}