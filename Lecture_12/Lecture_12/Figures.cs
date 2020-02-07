using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_12
{
    abstract class Figures
    {
        public string Name { get; set; }
        public Figures(string name)
        {
            Name = name;
        }
        public abstract double figureArea();
    }
    class Circle : Figures
    {
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
        public override double figureArea()
        {
            return Math.Round(2 * Math.PI * Math.Pow(Radius, 2));
        }
    }
    class Square : Figures
    {
        public double SquareSide { get; set; }
        public Square(string name, double squareSide) : base(name)
        {
            SquareSide = squareSide;
        }
        public override double figureArea()
        {
            return Math.Round(Math.Pow(SquareSide, 2));
        }
    }
    class Triangle : Figures
    {
        public double TriangleSide { get; set; }
        public Triangle(string name, double triangleSide) : base(name)
        {
            TriangleSide = triangleSide;
        }
        public override double figureArea()
        {
            return Math.Round(0.5 * TriangleSide * Math.Sqrt(Math.Pow(TriangleSide, 2) - (Math.Pow(TriangleSide, 2) / 4)));
        }
    }
}
