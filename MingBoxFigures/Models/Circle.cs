using MindBoxFigures.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxFigures.Models
{
    public class Circle : Figure
    {
        public double radius { get; init; }
        public Circle(double rad)
        {
            if (rad < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным!");
            radius = rad;
        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
