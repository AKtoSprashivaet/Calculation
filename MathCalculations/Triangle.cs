using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalculations
{
    public class Triangle
    {
        public Triangle() { }

        //Площадь треугольника, если не прямоугольный

        public double CalculatingTheArea(int ASide, int BSide, int CSide)
        {
            double S = CheckTriangle(ASide, BSide, CSide);
            int p;
            if (S == -1)
            {
                p = CalculatingSemiperimeter(ASide, BSide, CSide);
                S = Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
            }
            return S ;
        }

        //Подсчет полупериметра
        private int CalculatingSemiperimeter(int ASide, int BSide, int CSide)
        {
            int p;
            p = (ASide + BSide + CSide) / 2;
            return p;
        }

        //Проверка всех вариантов сторон
        private int CheckTriangle(int ASide, int BSide, int CSide)
        {
            if (ASide > BSide && ASide > CSide)
            {
                return CalculatingRectangular(BSide, CSide, ASide);
            } else if (BSide > ASide && BSide > CSide)
            {
                return CalculatingRectangular(ASide, CSide, BSide); 
            } else if (CSide > ASide && CSide > BSide)
            {
                return CalculatingRectangular(ASide, BSide, CSide);
            }
            return -1;
        }

        //Подсчет площади 
        private int CalculatingRectangular(int ASide, int BSide, int CSide)
        {
            int S;
            int p;
            //Если треугольник прямоугольный
            if (CheckRectangular(ASide, BSide, CSide))
            {
                p = CalculatingSemiperimeter(ASide, BSide, CSide);
                S = (p - ASide) * (p - BSide);
                return S;
            }
            return -1;
        }

        //Треугольник прямоугольный?
        private bool CheckRectangular(int ASide, int BSide, int CSide)
        {
            int check = ASide * ASide + BSide * BSide;
            if (check == CSide)
            {
                return true;
            }
            return false;
        }

    }
}
