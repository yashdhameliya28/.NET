using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Manual.lab_3
{
    public class NumberNotEven: Exception
    {
       
        public NumberNotEven(string message) : base(message)
        {
        }
    }
}
