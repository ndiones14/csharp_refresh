using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void Calc(double radius)
        {
            double area, circ;
            area = 3.14 * radius * radius;
            circ = 2 * 3.14 * radius;
            Console.WriteLine("Area of circle is: {0} \nCircumference of circle is {1}", area, circ);
        }
        static void Main(string[] args)
        {
            double radius;
            Console.WriteLine("Enter Radius  ");
            radius = Convert.ToDouble(Console.ReadLine());
            Program obj = new Program();
            obj.Calc(radius);

        }
    }
}
