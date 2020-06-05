using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        Random rnd = new Random();
        public int plus(int a, int b)
        {
            return a + b;
        }
        public int minus(int a, int b)
        {
            return a - b;
        }
        public int divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else { return -1; }
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }
        public int RetRand()
        {
            return rnd.Next(0, 10);
        }
    }
}
