using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphsim
{
    public class Geometry
    {

        public virtual double Area()
        {
            double areaValue = 0;
            return areaValue;
        }
    }
    public class Rectangle : Geometry
    {
        public double _length { get; set; }
        public double _width { get; set; }
        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }
        public override double Area()
        {
            return _length * _width;
        }
    }
    public class Circle : Geometry
    {
        public double _radius { get; set; }
        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }
    public class Square : Geometry
    {
        public double _side { get; set; }
        public Square (double side)
        {
            _side = side;
        }
        public override double Area()
        {
            return _side* _side;
        }
    }
    public class Triangle : Geometry
    {
        public double _sideA { get; set; }
        public double _sideB { get; set; }
        public double _sideC { get; set; }
        public Triangle(double sideA,double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public override double Area()
        {
            return (_sideA + _sideB + _sideC) / 2;
        }
    }
}
