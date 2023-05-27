using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalculations
{
    public class Circle
    {
        public Circle() { }

        //Площадь окружности по радиусу
        public double CalculatingTheArea(double radius)
        {
            double S;
            double pi = Math.PI;
            if (radius > 0)
            {
                S = pi * radius * radius;
            }
            else S = -1;
            return S;
        }
    }
}
