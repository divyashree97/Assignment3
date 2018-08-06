using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment31
{
   
    class Shapes

    {

        double area;
        [methodinfo(methodname = "displayarea", returntype = "void ", parameters = "radius", message = "to calculate the area of  the circle")]

        public void DispalyArea(double a)

        {

            area = 3.14 * a * a;

            Console.WriteLine("Area :" + area);

            //Console.WriteLine(DateTime.Now.Month);

        }

        [methodinfo(methodname = "displayarea", returntype = "void ", parameters = "radius", message = "to calculate the area of  rectangle")]

        public void DispalyArea(double l, double b)

        {

            area = l * b;

            Console.WriteLine("Area :" + area);

        }

        [methodinfo(methodname = "displayarea", returntype = "void ", parameters = "radius", message = "to calculate the area of  the triangle")]

        public void DispalyArea(double h, double b, double half)

        {

            area = half * b * h;

            Console.WriteLine("Area :" + area);

        }

    }
}
