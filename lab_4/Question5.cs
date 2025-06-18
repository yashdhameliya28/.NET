using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Question5
    {
        public void area(int length)
        {
            Console.WriteLine($"Area of square is {length * length}");
        }

        public void area(int length, int height)
        {
            Console.WriteLine($"Area of reactangle is {length * height}");
        }

        public void area(double radius)
        {
            Console.WriteLine($"Area of circle is {Math.PI*radius*radius}");
        }
    }
}
