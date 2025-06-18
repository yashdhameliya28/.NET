using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Manual.lab_2
{
    internal class Distance
    {
        public double dis1, dis2, dis3;
        public Distance(double dis1, double dis2) {
            this.dis1 = dis1;
            this.dis2 = dis2; 
        }

        public void additionDis3()
        {
            this.dis3 = this.dis1 + this.dis2;
        }

        public void display()
        {
            Console.WriteLine($"Total distance is {this.dis3}");
        }
    }
}
