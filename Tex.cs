using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6115261019_w09
{
    class Tex
    {
        public static double calculate(double salary)
        {
            double tex = 0;
            if (salary <= 8000)
            {
                tex = 0;
            }
            else if (salary <= 10000)
            {
                tex = (salary - 5000) * 0.05;
            }
            else if (salary <= 20000)
            {
                tex = (salary - 10000) * 0.1;
            }
            else if (salary <= 30000)
            {
                tex = (salary - 15000) * 0.15;
            }
            else if (salary >= 100000)
            {
                tex = (salary) * 0.35;
            }

            return tex;
        }
    }
}
