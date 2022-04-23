using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4_Task
{
    class Complex
    {
        //i - imaginary unit
        //a-Re
        //b-Im

        double re;
        double im;

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }

        public static Complex operator +(Complex oneNumber, Complex twoNumber)
        {
            return new Complex(oneNumber.Re + twoNumber.Re, oneNumber.Im + twoNumber.Im);
        }

        public static Complex operator +(Complex oneNumber, double number)
        {
            return new Complex(oneNumber.Re + number, oneNumber.Im );
        }

        public static Complex operator +(double number, Complex oneNumber)
        {
            return new Complex(oneNumber.Re + number, oneNumber.Im);
        }

        public static Complex operator -(Complex oneNumber, Complex twoNumber)
        {
            return new Complex(oneNumber.Re - twoNumber.Re, oneNumber.Im - twoNumber.Im);
        }

        public static Complex operator /(Complex oneNumber, Complex twoNumber)
        {
            double z = twoNumber.Re * twoNumber.Re + twoNumber.Im * twoNumber.Im;
            return new Complex((oneNumber.Re * twoNumber.Re + oneNumber.Im * twoNumber.Im) / z, (twoNumber.Re * oneNumber.Im - oneNumber.Re * twoNumber.Im) / z);

        }

        public static Complex operator *(Complex oneNumber, Complex twoNumber)
        {
            return new Complex(oneNumber.Re * twoNumber.Re - oneNumber.Im * twoNumber.Im, oneNumber.Re * twoNumber.Im + oneNumber.Im * twoNumber.Re);
        }

        public static Complex operator ++(Complex oneNumber)
        {
            return new Complex(oneNumber.Re++, oneNumber.Im++);
        }

        public static Complex operator --(Complex oneNumber)
        {
            return new Complex(oneNumber.Re--, oneNumber.Im--);
        }

        public static bool operator ==(Complex oneNumber, Complex twoNumber)
        {
            return oneNumber.Re == twoNumber.Re && oneNumber.Im == twoNumber.Im;
        }

        public static bool operator !=(Complex oneNumber, Complex twoNumber)
        {
            return oneNumber.Re != twoNumber.Re || oneNumber.Im != twoNumber.Im;
        }


        public double module()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }

        public static bool operator <(Complex oneNumber, Complex twoNumber)
        {
            return oneNumber.module() < twoNumber.module();
        }

        public static bool operator >(Complex oneNumber, Complex twoNumber)
        {
            return oneNumber.module() > twoNumber.module();
        }

        public static bool operator true(Complex oneNumber)
        {
            return oneNumber.Re != 0 || oneNumber.Im != 0;
        }

        public static bool operator false(Complex oneNumber)
        {
            return oneNumber.Re == 0 && oneNumber.Im == 0;
        }
        public double this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Re;
                }
                if (index == 1)
                {
                    return Im;
                }
                throw new Exception("Invalid index");
            }
            set
            {
                if (index == 0)
                {
                    Re = value;
                }
                if (index == 1)
                {
                    Im = value;
                }
            }
        }

        public static implicit operator Complex(double number)
        {
            return new Complex(number, 0);
        }

        public static explicit operator double(Complex oneNumber)
        {
            return oneNumber.module();
        }


        public override string ToString()
        {
            return $"{Re:0.##} + ({Im:0.##}) * i";
        }
    }
}
