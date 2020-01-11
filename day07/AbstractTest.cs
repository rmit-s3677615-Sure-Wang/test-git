using System;
using System.Collections.Generic;
using System.Text;

namespace day07
{
    class AbstractTest
    {
        public static void Mainsdss(string[] args)
        {
            // 使用多态求矩形的面积和周长，以及圆形的面积和周长
            Shape shape = new Circle(5);
            Shape shape2 = new Rectangular(5, 6);

            Console.WriteLine("the area for circle {0:0.00}, all lines {1:0.00}", shape.GetArea(), shape.GetPerimeter());
            Console.WriteLine("the area for rectangular {0:0.00}, all lines {1:0.00}", shape2.GetArea(), shape2.GetPerimeter());

        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Circle : Shape
    {
        private double _r;
        public double R
        {
            get { return _r; }
            set { _r = value; }

        }

        public Circle(double r)
        {
            this.R = r;
        }
        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double GetPerimeter()
        {
           return Math.PI*this.R*2;
        }
    }

    public class Rectangular : Shape
    {
        private double _height;
        public double _width;

        public double Height
        {
            get{ return _height; }
            set{ _height = value; }
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        
        }

        public Rectangular(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double GetArea()
        {
            return this.Width * this.Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (this.Width+this.Height);
        }
    }
}
