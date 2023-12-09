using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    public class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>    
    {
        private BigInteger nom;
        private BigInteger denom;

        //_____________________________Constructors____________________________
        public MyFrac()
        {
            nom = 0;
            denom = 1;
        }
        public MyFrac(int nom, int denom)
        {
            this.nom = new BigInteger(nom);
            this.denom = new BigInteger(denom);
        }
        public MyFrac(double nom, double denom)
        {
            this.nom = new BigInteger(nom);
            this.denom = new BigInteger(denom);
        }
        public MyFrac(BigInteger nom1, BigInteger denom1)
        {
            if (denom < 0)
            {
                nom = -nom1;
                denom = -denom1;
            }
            else
            {
                nom = nom1;
                denom = denom1;
            }
            nom1 = Math.Abs((long)nom);
            denom1 = Math.Abs((long)denom);
            while (nom1 != 0 && denom1 != 0)
            {
                if (nom1 > denom1)
                {
                    nom1 %= denom1;
                }
                else
                    denom1 %= nom1;
            }
            nom /= nom1 + denom1;
            denom /= nom1 + denom1;

        }
        //_____________________________________________________________________


        //_______________________________Functions_____________________________
        public MyFrac Add(MyFrac that) // Додавання
        {
            return new MyFrac(BigInteger.Add(BigInteger.Multiply(this.nom, that.denom),
            BigInteger.Multiply(this.denom, that.nom)),

            BigInteger.Multiply(this.denom, that.denom));

        }
        public MyFrac Subtract(MyFrac that) // Віднімання
        {
            return new MyFrac(BigInteger.Subtract(BigInteger.Multiply(this.nom, that.denom),
                              BigInteger.Multiply(this.denom, that.nom)),
                              BigInteger.Multiply(this.denom, that.denom));
        }
        public MyFrac Multiply(MyFrac that) // Множення
        {
            return new MyFrac(BigInteger.Multiply(this.nom, that.nom),
                               BigInteger.Multiply(this.denom, that.denom));
        }
        public MyFrac Divide(MyFrac that) // Ділення
        {
            return new MyFrac(BigInteger.Multiply(this.nom, that.denom),
                              BigInteger.Multiply(this.denom, that.nom));
        }
        public int CompareTo(MyFrac that) // Компаратор
        {
            return ((double)this.nom / (double)this.denom).CompareTo(((double)that.nom / (double)that.denom));

        }
        public override string ToString() // ТуСтрінг
        {
            return nom + "/" + denom;
        }
        //_____________________________________________________________________ 
    }
}
