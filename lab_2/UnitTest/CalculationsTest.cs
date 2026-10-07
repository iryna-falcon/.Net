using lab_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class CalculationsTest
    {
        [TestMethod]
        public void Task1_CountGreaterThanThree_ReturnsCorrectCount()
        {
            var task = new Task1(4, 2, 5);
            var expected = 2;

            var actual = task.CountGreaterThanThree();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_CalculateSum_ReturnsCorrectSum()
        {
            var task = new Task2(1, 10);
            var expected = 10;

            var actual = task.CalculateSum();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_CalculateSum_ThrowsExceptionIfAGreaterThanB()
        {
            var task = new Task2(10, 1);

            try
            {
                task.CalculateSum();
                Assert.Fail("Очікувалась помилка ArgumentOutOfRangeException, але метод її не викликав.");
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        [TestMethod]
        public void Task3_Tetrahedron_Volume_CalculatesCorrectly()
        {
            var tet = new Tetrahedron(3);
            var expected = (27 * Math.Sqrt(2)) / 12.0;

            var actual = tet.CalculateVolume();

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Task3_Tetrahedron_Height_CalculatesCorrectly()
        {
            var tet = new Tetrahedron(3);

            var expected = 3 * Math.Sqrt(2.0 / 3.0);

            var actual = tet.CalculateHeight();

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Task3_Tetrahedron_SurfaceArea_CalculatesCorrectly()
        {
            var tet = new Tetrahedron(3);

            var expected = 9 * Math.Sqrt(3);

            var actual = tet.CalculateSurfaceArea();

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Task3_Tetrahedron_SurfaceArea_CalculatesCorrectly_Negative()
        {
            try
            {
                var tet = new Tetrahedron(-3);

                var actual = tet.CalculateSurfaceArea();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            //Assert.Throws<ArgumentOutOfRangeException>(() => new Tetrahedron(-3));
        }
    }
}