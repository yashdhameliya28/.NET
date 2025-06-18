using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Hospital
    {
        public virtual void hospitalDetails()
        {
            Console.WriteLine("This is hospital class");
        }
    }

    public class Apollo:Hospital
    {
        public override void hospitalDetails()
        {
            Console.WriteLine("This is Apollo hospital");
        }
    }

    public class Wockhardt : Hospital
    {
        public override void hospitalDetails()
        {
            Console.WriteLine("This is Wockhardt hospital");
        }
    }
    public class Gokul_Superspeciality : Hospital
    {
        public override void hospitalDetails()
        {
            Console.WriteLine("This is Gokul_Superspeciality hospital");
        }
    }
}
