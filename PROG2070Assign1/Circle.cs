/*
 * PROG 2070
 * By: Justin Harvey
 * Assignment 1
 * Circle.cs
 * Professor: Rob Bowyer
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace PROG2070Assign1
{
    /// <summary>
    /// Circle class contains caluclations for the main program
    /// </summary>
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
        /// <summary>
        /// Returns the Radius of the Circle based on user input
        /// </summary>
        /// <returns></returns>
        public int GetRadius()
        {
            return radius;
        }
        /// <summary>
        /// Sets a new Radius for the circle replacing the previous set one
        /// </summary>
        /// <param name="userRadius"></param>
        public void SetRadius(int userRadius)
        {
            if (userRadius >= 1)
            {
                radius = userRadius; 
            }
            else
            {
                Console.WriteLine("Sorry the radius cannot be less than 1");
            }
        }
        /// <summary>
        /// Returns the Circumfrence of the circle based on the Radius input
        /// </summary>
        /// <returns></returns>
        public double GetCircumfrence()
        {
            circumfrence = Math.PI * (2 * radius);
            Console.WriteLine("The Circumfrence of the circle is: " + circumfrence);
            return circumfrence;

        }
        /// <summary>
        /// Returns the Area of the circle based on the Radius input
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double squaredRadius = radius * radius;
            area = Math.PI * squaredRadius;
            Console.WriteLine("The Area of the circle is: " + area);
            return area;
        }

    }
}
