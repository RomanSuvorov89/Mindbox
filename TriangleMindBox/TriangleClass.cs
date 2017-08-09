using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleMindBox
{
    public class TriangleClass
    {
        private double a;
        private double b;
        private double c;
        protected double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                { throw new ArgumentException("Error: ArgumentExeption A"); }
                else a = value;  
            }
        }
        protected double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                { throw new ArgumentException("Error: ArgumentExeption B"); }
                else b = value;
            }
        }
        protected double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                { throw new ArgumentException("Error: ArgumentExeption C"); }
                else c = value;
            }
        }

        public TriangleClass(double valueA, double valueB, double valueC)
        {
            if ((valueA + valueB >= valueC ) && ( valueA + valueC >= valueB ) && ( valueB + valueC >= valueA ))
            {
                A = valueA;
                B = valueB;
                C = valueC;
            }
            else
            {
                throw new ArgumentException("Error: Triangle does not exist, check the parameters");
            }
        }
        public double Square()
        {
            double[] TriangleSide = new double[3] { a, b, c };
            Array.Sort(TriangleSide);
            if (Math.Abs(TriangleSide[0] * TriangleSide[0] + TriangleSide[1] * TriangleSide[1] - TriangleSide[2] * TriangleSide[2]) != 0)
            {
                throw new ArgumentException("it's not right triangle");
            }
            else return (TriangleSide[0]  * TriangleSide[1]) / 2;
        }
    }
}
