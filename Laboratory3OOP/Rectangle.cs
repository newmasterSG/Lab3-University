using System;

namespace Laboratory3OOP
{
    internal class Rectangle
    {
        private readonly double _side1;

        private readonly double _side2;
        public Rectangle(double side1, double side2) 
        {
            this._side1 = side1;
            this._side2 = side2;
        }

        private double _area;
        public double Area
        {
            get
            {
                return _area;
            }
        }
        public double AreaCalculator() => _area = _side1 * _side2;

        private double _perimeter;
        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
        }
        public double PerimeterCalculator() => _perimeter = 2 * (_side1 + _side2);
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.0, 6.0);
            Console.WriteLine(rectangle.PerimeterCalculator());
            Console.WriteLine(rectangle.AreaCalculator());
        }
    }
}
