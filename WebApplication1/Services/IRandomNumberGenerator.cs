using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public interface IRandomNumberGenerator
    {
        int plus(int a, int b);
        int minus(int a, int b);
        int divide(int a, int b);
        int multiply(int a, int b);
        int RetRand();
    }
}
