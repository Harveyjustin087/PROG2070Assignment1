using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PROG2070Assign1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            int newRadius = 0;

            Circle circ = new Circle();
            try
            {
                while (selection != 5)
                {
                    Console.WriteLine("Hello Welcome!");
                    Console.WriteLine("1. Get Circle Radius\n" +
                        "2. Change Circle Radius \n" +
                        "3. Get Circle Circumference \n" +
                        "4. Get Circle Area \n" +
                        "5. Exit ");
                    selection = Convert.ToInt32(Console.ReadLine());
                    if (selection == 1)
                    {
                        Console.WriteLine("Pleases enter a Radius");
                        circ.Radius = Convert.ToInt32(Console.ReadLine());
                        circ.GetRadius();
                    }
                    else if (selection == 2)
                    {
                        Console.WriteLine("Pleases enter a new Radius");
                        newRadius = int.Parse(Console.ReadLine());
                        circ.SetRadius(newRadius);
                    }
                    else if (selection == 3)
                    {
                        circ.GetCircumfrence();
                    }
                    else if (selection == 4)
                    {
                        circ.GetArea();
                    }
                    else
                    {
                        Console.WriteLine("Sorry Invalid Selection");
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error at: {ex.Message}");
            }
        }
    }
}