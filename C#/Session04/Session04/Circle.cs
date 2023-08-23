using GeometricObjectDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    //Circle class extends GeometricObject class
    public class Circle : GeometricObject
    {
        private double radius;
        public Circle(double x)
        {
            this.radius = x;
        }

        public Circle(double x, string c, double w) : base(c, w)
        {
            this.radius = x;
        }

        public override String ToString()
        {
            return "Circle has: radius is " + radius + ", color is " + PColor + ", weight is " + PWeight;
        }

        public override double findArea() { return Math.PI * radius * radius; }

        public override double findPerimeter() { return 2 * Math.PI * radius; }

    }


}
