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
        public Rectangle()
        {
            _length = 4;
            _width = 7.5;
        }
        public override double Area()
        {
            return _length * _width;
        }
    }
    public class Circle : Geometry
    {
        public double _radius { get; set; }
        public Circle()
        {
            _radius = 6.8;
        }
        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }
    public class Square : Geometry
    {
        public double _side { get; set; }
        public Square ()
        {
            _side = 7.9;
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
        public Triangle()
        {
            _sideA = 7.3;
            _sideB = 6;
            _sideC = 14.9;
        }
        public override double Area()
        {
            return (_sideA + _sideB + _sideC) / 2;
        }
    }
}
