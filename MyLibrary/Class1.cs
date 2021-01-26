using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Class1
    {
        public double square(double value) 
        {
            double pi = 3.14;
            double S = pi * value * value;
            return S;

        }
    
        public  double Triangle(double FirstValue, double SecondValue, double ThirdValue)
        {
            double P, S;    

            if (FirstValue > SecondValue & FirstValue > ThirdValue)
            {
                double F_value = FirstValue * FirstValue;
                if (F_value == (SecondValue * SecondValue) + (ThirdValue * ThirdValue))
                {
                    Console.WriteLine("Треугольник является прямоугольным! ");
                }
            }

            if (SecondValue > FirstValue & SecondValue > ThirdValue)
            {
                double S_value = SecondValue * SecondValue;
                if (S_value == (FirstValue * FirstValue) + (ThirdValue * ThirdValue))
                {
                    Console.WriteLine("Треугольник является прямоугольным! ");
                }
            }

            if (ThirdValue > SecondValue & ThirdValue > FirstValue)
            {
                double T_value = ThirdValue * ThirdValue;
                if (T_value == (SecondValue * SecondValue) + (FirstValue * FirstValue))
                {
                    Console.WriteLine("Треугольник является прямоугольным! ");
                }
            }

            P = (FirstValue + SecondValue + ThirdValue) / 2;
            S = Math.Sqrt(P * (P - FirstValue) * (P - SecondValue) * (P - ThirdValue));
            return S;
        }
    
    }
}
