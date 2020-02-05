using System;
using System.Collections.Generic;
using System.Text;

namespace PROG2070Assign1
{
    public class Circle
    {
        private int radius;
        public double circumfrence = 0.0;
        public double area = 0.0;

        public int Radius { get => radius; set => radius = value; }

        public Circle()
        {
            radius = 1;
        }
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public int GetRadius()
        {
            //Console.WriteLine("Pleases enter a Radius");
            //radius = Convert.ToInt32(Console.ReadLine());
            return radius;
        }
        public void SetRadius(int userRadius)
        {
            radius = userRadius;
        }
        public double GetCircumfrence()
        {
            circumfrence = Math.PI * (2 * radius);
            Console.WriteLine("The Circumfrence of the circle is: " + circumfrence);
            return circumfrence;

        }
        public double GetArea()
        {
            double squaredRadius = radius * radius;
            area = Math.PI * squaredRadius;
            Console.WriteLine("The Area of the circle is: " + area);
            return area;
        }

    }
}
