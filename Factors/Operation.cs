using System;
using System.Collections.Generic;
using System.Text;

namespace Factors
{
    class Operation
    {


        //Interes compuesto
        public double factorF_P(double P,float i, int n)
        {
                return P * Math.Pow((1+i),n);
        }
        public double factorP_F(double F,float i,int n)
        {

                return F*Math.Pow((1+i),-1*n);
        }

        //Interes y anualidades
        public double factorF_A(double A,float i, int n)
        {
            if (i==0)
            {
                throw new Exception("i no puede ser 0");
            }
            return A*(Math.Pow(1+i,n)/i);
        }
        public double factorA_F(double F,float i, int n)
        {
            if (i == 0)
            {
                throw new Exception("i no puede ser 0");
            }
            return F * (i/(Math.Pow(1+i,n)-1));
        }
        public double factorP_A(double A, float i, int n)
        {
            if (i == 0)
            {
                throw new Exception("i no puede ser 0");
            }
            return A*((Math.Pow(1+i,n)-1)/(i*Math.Pow(1+i,n)));
        }
        public double factorA_P(double P, float i, int n)
        {
            if (i == 0)
            {
                throw new Exception("i no puede ser 0");
            }
            return P*((i*Math.Pow(i+1,n))/(Math.Pow(1+i,n)-1));
        }


        public double factorP_G(double G, float i, int n)
        {
            if (i == 0)
            {
                throw new Exception("i no puede ser 0");
            }
            return G*((Math.Pow(i+1,n)-i*n-1)/(Math.Pow(i,2)*Math.Pow(i+1,n)));
        }
        public double factorA_G(double G, float i, int n)
        {
            if (i == 0)
            {
                throw new Exception("i no puede ser 0");
            }
            return G*((Math.Pow(i+i,n)-i*n-1)/(i*(Math.Pow(i+1,n)-1)));
        }
        public double factorP_A1(double A1, float g,float i, int n)
        {
            if (i == 0)
            {
                throw new Exception("i no puede ser 0");
            }
            if (g== 0)
            {
                throw new Exception("g no puede ser 0");
            }

            if (g == i)
            {
                return A1 * (n / (1 + i));
            }
            else
            {
                return A1 * ((1 - Math.Pow(i + g, n) * Math.Pow(i + 1, -1 * n)) / (i - g));
            }            
        }

    }
}
