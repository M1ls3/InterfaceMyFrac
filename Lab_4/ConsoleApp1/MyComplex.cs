using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    public class MyComplex : IMyNumber<MyComplex>
    {
        private BigInteger re;
        private BigInteger im;

        //_____________________________Constructors____________________________
        public MyComplex()
        {
            this.re = 0;
            this.im = 1;
        }
        public MyComplex(int nom, int denom)
        {
            this.re = new BigInteger(nom);
            this.im = new BigInteger(denom);
        }
        public MyComplex(double re, double im)
        {
            this.re = new BigInteger(re);
            this.im = new BigInteger(im);
        }
        public MyComplex(BigInteger re, BigInteger im)
        {
            this.re = re;
            this.im = im;
        }
        //_____________________________________________________________________

        //_______________________________Functions_____________________________
        public MyComplex Add(MyComplex that) // Додавання
        {
            return new MyComplex(this.re + that.re, this.im + that.im);
        }
        public MyComplex Subtract(MyComplex that) // Віднімання
        {
            return new MyComplex(this.re - that.re, this.im - that.im);

        }
        public MyComplex Multiply(MyComplex that) // Множення
        {
            return new MyComplex(BigInteger.Multiply(this.re, that.re) - BigInteger.Multiply(this.im, that.im),
                                 BigInteger.Multiply(this.re, that.im) + BigInteger.Multiply(this.im, that.re));
        }
        public MyComplex Divide(MyComplex that) // Ділення 
        {
            if (that.re == 0 && that.im == 0) throw new DivideByZeroException();
            return new MyComplex(BigInteger.Divide(BigInteger.Multiply(this.re, that.re) + BigInteger.Multiply(this.im, that.im), BigInteger.Multiply(that.re, that.re) + BigInteger.Multiply(that.im, that.im)),
                                 BigInteger.Divide(BigInteger.Multiply(this.im, that.re) - BigInteger.Multiply(this.re, that.im), BigInteger.Multiply(that.re, that.re) + BigInteger.Multiply(that.im, that.im)));
        }
        public override string ToString() // ТуСтрінг
        {
            if (this.im < 0)
                return this.re + "" + this.im + "i";
            else
                return this.re + "+" + this.im + "i";
        }
        //_____________________________________________________________________
    }
}
