using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Numbers
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public string operation { get; set; }
        public int numData { get; set; }
        public void Count()
        {
            if (operation == "+")
            {
                numData = num1 + num2;
            }
            else if (operation == "-")
            {
                numData = num1 - num2;
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    numData = num1 / num2;
                }
                else numData = -1;
            }
            else if (operation == "*")
            {
                numData = num1 * num2;
            }
        }
    }
}
