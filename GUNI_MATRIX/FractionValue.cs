using System;
using System.Numerics;

namespace GUNI_MATRIX
{
    public struct FractionValue
    {

        public BigInteger Numerator { get; set; }
        public BigInteger Denominator { get; set; }


        public static readonly char Separator = '/';

        public FractionValue(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public FractionValue(long numerator, long denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }


        public FractionValue(BigInteger numerator, BigInteger denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public FractionValue(FractionValue fV)
        {
            this.Numerator = fV.Numerator;
            this.Denominator = fV.Denominator;
        }

        public FractionValue(string str)
        {
            var res = str.Split(Separator);

            try
            {
                if (res.Length == 2)
                {
                    Numerator = BigInteger.Parse(res[0]);
                    Denominator = BigInteger.Parse(res[1]);
                }
                else
                {
                    Denominator = 1;
                    Numerator = BigInteger.Parse(str);
                }
            }
            catch
            {
                Numerator = 1;
                Denominator = 1;
            }
        }

        public override string ToString()
        {
            switch (Denominator.ToString())
            {
                case "1":
                    return Numerator.ToString();
                case "-1":
                    Numerator *= -1;
                    Denominator = 1;
                    return Numerator.ToString();
                default:
                    if(Numerator == 0 && Denominator != 0)
                        return 0.ToString();
                    return $"{Numerator}{Separator}{Denominator}";
            }
        }

        public double ToDouble()
        {
            return ((double)Numerator / (double)Denominator);
        }

        static BigInteger gcd(BigInteger a, BigInteger b)
        {
            while (a != 0 && b != 0)
                if (a > b) a %= b;
                else b %= a;
            return a + b;
        }
        public static FractionValue DownSize(FractionValue fV)
        {
            while (true)
            {
                if (fV.Numerator > -1 && fV.Numerator < 2 || fV.Denominator > -1 && fV.Denominator < 2)
                {
                    return fV;
                }


                var sign = 0;
                if (fV.Numerator < 0)
                {
                    sign++;
                    fV.Numerator *= -1;
                }

                if (fV.Denominator < 0)
                {
                    sign++;
                    fV.Denominator *= -1;
                }

                var res = gcd(fV.Numerator, fV.Denominator);
                if (res == 1 || res > fV.Numerator || res > fV.Denominator)
                {
                    if (sign == 1)
                    {
                        fV.Numerator *= -1;
                    }
                    return fV;
                }

                if (sign == 1)
                {
                    fV.Numerator *= -1;
                }
                fV.Numerator /= res;
                fV.Denominator /= res;

                

            }
        }


        public static FractionValue operator +(FractionValue fvA, FractionValue fvB)
        {
            if (fvA.Denominator != fvB.Denominator)
            {
                fvA.Numerator *= fvB.Denominator;
                fvB.Numerator *= fvA.Denominator;
                fvA.Denominator *= fvB.Denominator;
                fvA.Numerator += fvB.Numerator;
                return DownSize(fvA);
            }

            fvA.Numerator += fvB.Numerator;
            return DownSize(fvA);
        }

        public static FractionValue operator +(FractionValue fvA, int b)
        {
            var fvB = new FractionValue(b, 1);
            if (fvA.Denominator != fvB.Denominator)
            {
                fvA.Numerator *= fvB.Denominator;
                fvB.Numerator *= fvA.Denominator;
                fvA.Denominator *= fvB.Denominator;
                fvA.Numerator += fvB.Numerator;
                return DownSize(fvA);
            }

            fvA.Numerator += fvB.Numerator;
            return DownSize(fvA);
        }

        public static FractionValue operator +(FractionValue fvA, BigInteger b)
        {
            var fvB = new FractionValue(b, 1);
            if (fvA.Denominator != fvB.Denominator)
            {
                fvA.Numerator *= fvB.Denominator;
                fvB.Numerator *= fvA.Denominator;
                fvA.Denominator *= fvB.Denominator;
                fvA.Numerator += fvB.Numerator;
                return DownSize(fvA);
            }

            fvA.Numerator += fvB.Numerator;
            return DownSize(fvA);
        }


        public static FractionValue operator -(FractionValue fvA, FractionValue fvB)
        {
            if (fvA.Denominator != fvB.Denominator)
            {
                fvA.Numerator *= fvB.Denominator;
                fvB.Numerator *= fvA.Denominator;
                fvA.Denominator *= fvB.Denominator;
                fvA.Numerator -= fvB.Numerator;
                return DownSize(fvA);
            }

            fvA.Numerator -= fvB.Numerator;
            return DownSize(fvA);
        }


        public static FractionValue operator -(FractionValue fvA, int b)
        {
            var fvB = new FractionValue(b, 1);
            if (fvA.Denominator != fvB.Denominator)
            {
                fvA.Numerator *= fvB.Denominator;
                fvB.Numerator *= fvA.Denominator;
                fvA.Denominator *= fvB.Denominator;
                fvA.Numerator -= fvB.Numerator;
                return DownSize(fvA);
            }

            fvA.Numerator -= fvB.Numerator;
            return DownSize(fvA);
        }


        public static FractionValue operator -(FractionValue fvA, BigInteger b)
        {
            var fvB = new FractionValue(b, 1);
            if (fvA.Denominator != fvB.Denominator)
            {
                fvA.Numerator *= fvB.Denominator;
                fvB.Numerator *= fvA.Denominator;
                fvA.Denominator *= fvB.Denominator;
                fvA.Numerator -= fvB.Numerator;
                return DownSize(fvA);
            }

            fvA.Numerator -= fvB.Numerator;
            return DownSize(fvA);
        }


        public static FractionValue operator *(FractionValue fvA, FractionValue fvB)
        {
            fvA.Numerator *= fvB.Numerator;
            fvA.Denominator *= fvB.Denominator;
            return DownSize(fvA);
        }

        public static FractionValue operator *(FractionValue fvA, int b)
        {
            var fvB = new FractionValue(b, 1);
            fvA.Numerator *= fvB.Numerator;
            fvA.Denominator *= fvB.Denominator;
            return DownSize(fvA);
        }

        public static FractionValue operator *(FractionValue fvA, BigInteger b)
        {
            var fvB = new FractionValue(b, 1);
            fvA.Numerator *= fvB.Numerator;
            fvA.Denominator *= fvB.Denominator;
            return DownSize(fvA);
        }


        public static FractionValue operator /(FractionValue fvA, FractionValue fvB)
        {
            fvA.Numerator *= fvB.Denominator;
            fvA.Denominator *= fvB.Numerator;
            return DownSize(fvA);
        }

        public static FractionValue operator /(FractionValue fvA, int b)
        {
            var fvB = new FractionValue(b, 1);
            fvA.Numerator *= fvB.Denominator;
            fvA.Denominator *= fvB.Numerator;
            return DownSize(fvA);
        }

        public static FractionValue operator /(FractionValue fvA, BigInteger b)
        {
            var fvB = new FractionValue(b, 1);
            fvA.Numerator *= fvB.Denominator;
            fvA.Denominator *= fvB.Numerator;
            return DownSize(fvA);
        }

        public static FractionValue operator -(FractionValue fvA)
        {
            fvA.Numerator *= -1;
            return fvA;
        }

        public static bool operator >(FractionValue fvA, FractionValue fvB)
        {
            return fvA.ToDouble() > fvB.ToDouble();
        }
        public static bool operator <(FractionValue fvA, FractionValue fvB)
        {
            return fvA.ToDouble() < fvB.ToDouble();
        }
        public static bool operator >=(FractionValue fvA, FractionValue fvB)
        {
            return fvA > fvB || fvA == fvB;
        }
        public static bool operator <=(FractionValue fvA, FractionValue fvB)
        {
            return fvA < fvB || fvA == fvB;
        }
        public static bool operator !=(FractionValue fvA, FractionValue fvB)
        {
            return DownSize(fvA).ToString() != DownSize(fvB).ToString();
        }

        public static bool operator ==(FractionValue fvA, FractionValue fvB)
        {
            return DownSize(fvA).ToString() == DownSize(fvB).ToString();
        }

    }
}
