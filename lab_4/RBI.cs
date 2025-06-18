using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class RBI
    {
        public virtual void calculateInterest(double p, int t, double r)
        {
            Console.WriteLine($"calculateInterest from RBI : {(p*t*r)/100}");
        }
    }

    public class HDFC:RBI
    {
        public override void calculateInterest(double p, int t, double r)
        {
            Console.WriteLine($"calculateInterest from HDFC : {(p * t * r) / 100}");
        }
    }

    public class SBI : RBI
    {
        public override void calculateInterest(double p, int t, double r)
        {
            Console.WriteLine($"calculateInterest from SBI : {(p * t * r) / 100}");
        }
    }

    public class ICIC : RBI
    {
        public override void calculateInterest(double p, int t, double r)
        {
            Console.WriteLine($"calculateInterest from RBI : {(p * t * r) / 100}");
        }
    }
}
