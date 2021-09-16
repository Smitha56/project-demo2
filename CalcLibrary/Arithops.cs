using System;

namespace CalcLibrary
{
    public class Arithops : IArithops
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Pow(double x, double y, double result)
        {
            return(double) Math.Pow(x, y);
        }
        public double netsalary(double x,double y,double z,double p)
        {
            return x + y + z + p;
        }
       

    }
}
