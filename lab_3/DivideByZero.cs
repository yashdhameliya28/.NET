using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Manual.lab_3
{
    public class CustomDivideByZero: Exception
    {
        public CustomDivideByZero(string msg) : base(msg) { }
    }
}
