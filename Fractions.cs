// 1) Класс Дробное число со знаком (Fractions). Число должно быть представлено 
// двумя полями: целая часть - длинное целое со знаком, дробная часть - беззнаковое короткое целое.
//  Реализовать арифметические операции
//  сложения, вычитания, умножения и операции сравнения. В функции main проверить эти методы.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_1_exercise_OOP
{
    public class Fractions
    {
        public bool minus = false;
        private int intNum;
        public int IntegerNum
        {
            get { return intNum; }
            set
            {
                if (value < 0)
                {
                    minus = true;
                    intNum = value;
                }
                intNum = value;
            }
        }
        private double doubleNum;
        public double DoubleNum
        {
            get { return doubleNum; }
            set
            {
                if (value >= 1)
                {
                    IntegerNum += (int)Math.Floor(value);
                    doubleNum = value - Math.Floor(value);
                }
                else if (value >= 0 && value < 1)
                {
                    doubleNum = value;
                }
                else if (value < 0 && value > -1)
                {
                    doubleNum = Math.Abs(value);
                    if (!minus)
                    {
                        minus = true;
                    }
                }
                else if (value <= -1)
                {
                    IntegerNum += (int)Math.Floor(Math.Abs(value));
                    doubleNum = Math.Abs(value) - Math.Floor(Math.Abs(value));
                    if (!minus)
                    {
                        minus = true;
                    }
                }

            }
        }
        public Fractions(int IntegerNum, double doubleNum)
        {
            this.IntegerNum = IntegerNum;
            this.DoubleNum = doubleNum;
            if (minus && this.IntegerNum > 0)
            {
                this.IntegerNum = -this.IntegerNum;
            }
        }
        public double FullNum
        {
            get
            {
                if (IntegerNum < 0)
                {
                    return -(Math.Abs(IntegerNum) + doubleNum);
                }
                return IntegerNum + doubleNum;
            }
        }
        public static Fractions operator +(Fractions a, Fractions b)
        {
            double newValue = a.FullNum + b.FullNum;
            return new Fractions((int)newValue, Math.Abs(newValue) - Math.Floor(Math.Abs(newValue)));
        }
        public static Fractions operator -(Fractions a, Fractions b)
        {
            double newValue = a.FullNum - b.FullNum;
            return new Fractions((int)newValue, Math.Abs(newValue) - Math.Floor(Math.Abs(newValue)));
        }
        public static Fractions operator *(Fractions a, Fractions b)
        {
            double newValue = a.FullNum + b.FullNum;
            return new Fractions((int)newValue, Math.Abs(newValue) - Math.Floor(Math.Abs(newValue)));
        }
        public static Fractions operator /(Fractions a, Fractions b)
        {
            double newValue = a.FullNum / b.FullNum;
            return new Fractions((int)newValue, Math.Abs(newValue) - Math.Floor(Math.Abs(newValue)));
        }
        public static bool operator >(Fractions a, Fractions b) {
            if (a.IntegerNum > b.IntegerNum)
            {
                return true;
            }
            else if (a.IntegerNum == b.IntegerNum)
            {
                if (a.DoubleNum > b.DoubleNum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else {
                return false;
            }
        }
        public static bool operator <(Fractions a, Fractions b)
        {
            if (a.IntegerNum < b.IntegerNum)
            {
                return true;
            }
            else if (a.IntegerNum == b.IntegerNum)
            {
                if (a.DoubleNum < b.DoubleNum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
