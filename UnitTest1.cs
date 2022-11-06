using NUnit.Framework;
using Figures;

namespace TestFigures
{
    public class Tests
    {
        [Test]
        public void TestCircleArea_Rad1()
        {
            Circle circle = new Circle(new Distance(1));

            Assert.AreEqual(circle.EvaluateArea(), 3.14, 0.01);
        }

        [Test]
        public void TestCircleArea_Rad10()
        {
            Circle circle = new Circle(new Distance(10));

            Assert.AreEqual(circle.EvaluateArea(), 314.15, 0.01);
        }

        [Test]
        public void TestTriangleArea_Rad345()
        {
            Triangle triangle = new Triangle(new Distance(3), new Distance(4), new Distance(5));

            Assert.AreEqual(triangle.EvaluateArea(), 6, 0.01);
        }

        [Test]
        public void TestTriangleArea_Rad122()
        {
            Triangle triangle = new Triangle(new Distance(2), new Distance(2), new Distance(1));

            Assert.AreEqual(triangle.EvaluateArea(), 0.96, 0.01);
        }

        [Test]
        public void TestTriangleIsRight()
        {
            Triangle triangle = new Triangle(new Distance(3), new Distance(4), new Distance(5));

            Assert.IsTrue(triangle.IsRight());
        }

        [Test]
        public void TestTriangleIsFalse()
        {
            Triangle triangle = new Triangle(new Distance(3), new Distance(3), new Distance(5));

            Assert.IsFalse(triangle.IsRight());
        }
    }
}