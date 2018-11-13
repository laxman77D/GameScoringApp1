using System;
using System.Collections.Generic;

namespace SOLID_Principles
{
    public interface IShape
    {
        int Side { get; set; }
    }

    public interface IArea
    {
        double GetArea();
    }

    public interface IPerimeter
    {
        double GetPerimeter();
    }

    public interface IAreaCalculator
    {
        double CalculateArea(IList<IArea> shapes);
    }

    interface IPerimeterCalculator
    {
        double CalculatePerimeter(IList<IPerimeter> shapes);
    }

    public class AreaCalculator : IAreaCalculator
    {
        Logging _logging;
        public AreaCalculator()
        {
            _logging = new Logging();
        }

        public double CalculateArea(IList<IArea> shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.GetArea();
                _logging.Log(totalArea, "area", shape);
            }

            return totalArea;
        }
    }

    public class PerimeterCalculator : IPerimeterCalculator
    {
        Logging _logging;
        public PerimeterCalculator()
        {
            _logging = new Logging();
        }

        public double CalculatePerimeter(IList<IPerimeter> shapes)
        {
            double totalPerimeter = 0;
            foreach (var shape in shapes)
            {
                totalPerimeter += shape.GetPerimeter();
                _logging.Log(totalPerimeter, "perimeter", shape);
            }

            return totalPerimeter;
        }
    }

    public class Logging
    {
        public void Log(double perimeter, string type, IPerimeter shape)
        {
            Console.WriteLine(DateTime.Now + type + "method for " + shape + " is called : " + perimeter);
        }

        public void Log(double area, string type, IArea shape)
        {
            Console.WriteLine(DateTime.Now + type + "method for " + shape + " is called : " + area);
        }
    }

    public class Sqaure : IShape, IArea, IPerimeter
    {
        private int width;
        public Sqaure()
        {
        }

        public int Side
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
            double area = Side * Side;
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = 4 * Side;
            return perimeter;
        }
    }

    public class Circle : IShape, IArea, IPerimeter
    {
        private int width;
        public Circle()
        {
        }
        public int Side
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
            double area = Math.Round(Math.PI * (double)(Side / 2) * (double)(Side / 2));
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = Math.Round((Math.PI * (double)Side));
            return perimeter;
        }
    }

    public class Triangle : IShape, IArea, IPerimeter
    {
        private int side;
        public Triangle()
        {
        }
        public int Side
        {
            get { return side; }
            set { side = value; }
        }

        public double GetArea()
        {
            double area = Math.Round(Math.Sqrt(3) / 4 * side * side); // Assumed it's an equilateral triangle
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = 3 * (double)side;
            return perimeter;
        }
    }
}
