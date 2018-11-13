using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID_Principles;

namespace GameScoringAppTest
{
    [TestClass]
    public class SOLIDPropertiesUnitTest
    {
        [TestMethod]
        public void TestCalculateSquarePerimeter()
        {
            Sqaure obj = new Sqaure();
            obj.Side = 10;
            double result = obj.GetPerimeter();
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void TestCalculateSquareArea()
        {
            Sqaure obj = new Sqaure();
            obj.Side = 10;
            double result = obj.GetArea();
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void TestCalculateCircleArea()
        {
            Circle obj = new Circle();
            obj.Side = 10;
            double result = obj.GetArea();
            Assert.AreEqual(79, result);
        }

        [TestMethod]
        public void TestCalculateCirclePerimeter()
        {
            Circle obj = new Circle();
            obj.Side = 10;
            double result = obj.GetPerimeter();
            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void TestCalculateTriangleArea()
        {
            Triangle obj = new Triangle();
            obj.Side = 10;
            double result = obj.GetArea();
            Assert.AreEqual(43, result);
        }

        [TestMethod]
        public void TestCalculateTrianglePerimeter()
        {
            Triangle obj = new Triangle();
            obj.Side = 10;
            double result = obj.GetPerimeter();
            Assert.AreEqual(30, result);
        }
    }
}
