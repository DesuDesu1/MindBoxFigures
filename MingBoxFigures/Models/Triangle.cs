using MindBoxFigures.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxFigures.Models
{
    public class Triangle : Figure
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }
        public bool isRightAngled { get;}
        public Triangle(double sideA, double sideB, double sideC) 
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
                throw new ArgumentException("Сторона не может быть негативной!");
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            isRightAngled = IsRightAngled();
        }
        /// <summary>
        /// Проверить, является ли треугольник прямоугольным
        /// </summary>
        private bool IsRightAngled()
        {
            double A = Math.Pow(SideA, 2);
            double B = Math.Pow(SideB, 2);
            double C = Math.Pow(SideC, 2);
            return A + B == C || A + C == B || C + B == A;
        }
        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        public override double CalculateArea()
        {
            var semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
    }
}
