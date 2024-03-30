using MindBoxFigures.Models;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NUnitTests
{
    [TestFixture]
    public class AreaCalculatorTests
    {
        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [Test]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            var circle = new Circle(5);

            //Act
            var circleSquare = circle.CalculateArea();

            //Assert
            ClassicAssert.AreEqual(78.539816339744831, circleSquare);
        }

        /// <summary>
        /// Тестируем вычисление площади тиугольника
        /// </summary>
        [Test]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var triangleSquare = triangle.CalculateArea();

            //Assert
            ClassicAssert.AreEqual(6, triangleSquare);
        }

        /// <summary>
        /// Тестируем прямоугольный треугольник
        /// </summary>
        [Test]
        public void RightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var isTriangleRightAngled = triangle.isRightAngled;

            //Assert
            ClassicAssert.AreEqual(true, isTriangleRightAngled);
        }

        /// <summary>
        /// Тестируем не прямоугольный треугольник
        /// </summary>
        [Test]
        public void NotRightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(8, 2, 5);

            //Act
            var isTriangleRightAngled = triangle.isRightAngled;

            //Assert
            ClassicAssert.AreEqual(false, isTriangleRightAngled);
        }
    }
}
