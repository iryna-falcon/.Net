using lab_5.Toys;

namespace ToyInventoryApp.Tests
{
    [TestClass]
    public class ToyTests
    {
        [TestMethod]
        public void Constructor_WithValidArguments_CreatesToyObject()
        {
            string title = "Конструктор";
            decimal cost = 450.00m;
            int minAge = 6;
            int maxAge = 12;

            var toy = new Toy(title, cost, minAge, maxAge);

            Assert.AreEqual(title, toy.Title);
            Assert.AreEqual(cost, toy.Cost);
            Assert.AreEqual(minAge, toy.MinAge);
            Assert.AreEqual(maxAge, toy.MaxAge);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        public void Constructor_WithInvalidTitle_ThrowsArgumentException(string invalidTitle)
        {
            Assert.Throws<ArgumentException>(() => new Toy(invalidTitle, 100, 3, 5));
        }

        [TestMethod]
        public void CompareTo_ComparesByCostCorrectly()
        {
            var toy1 = new Toy("Лялька", 300m, 3, 8);
            var toy2 = new Toy("Робот", 1200m, 6, 12);

            Assert.IsLessThan(0, toy1.CompareTo(toy2));
            Assert.IsGreaterThan(0, toy2.CompareTo(toy1));
        }
    }
}
