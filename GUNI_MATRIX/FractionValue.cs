using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GUNI_MATRIX
{
    public struct FractionValue
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }


        public static readonly char Separator = '/';

        public FractionValue(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public FractionValue(string str)
        {
            var res = str.Split(Separator);

            try
            {
                if (res.Length == 2)
                {
                    Numerator = Convert.ToInt32(res[0]);
                    Denominator = Convert.ToInt32(res[1]);
                }
                else
                {
                    Denominator = 1;
                    Numerator = Convert.ToInt32(str);
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
            switch (Denominator)
            {
                case 1:
                    return Numerator.ToString();
                case -1:
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
            return (double)Numerator / Denominator;
        }


        public static FractionValue DownSize(FractionValue fV)
        {
            while (true)
            {
                if (fV.Numerator > -1 && fV.Numerator < 2 || fV.Denominator > -1 && fV.Denominator < 2)
                {
                    return fV;
                }

                var isDownSized = false;
                var numeratorB = false;
                var denominatorB = false;

                if (fV.Numerator < 0)
                {
                    fV.Numerator *= -1;
                    numeratorB = true;
                }

                if (fV.Denominator < 0)
                {
                    fV.Denominator *= -1;
                    denominatorB = true;
                }

                var min = fV.Numerator > fV.Denominator ? fV.Denominator : fV.Numerator;


                for (var i = min; i >= 2; i--)
                {
                    if (fV.Numerator % i != 0 || fV.Denominator % i != 0) continue;

                    fV.Numerator /= i;
                    fV.Denominator /= i;
                    isDownSized = true;
                }

                if (!(numeratorB && denominatorB))
                {
                    if (numeratorB)
                    {
                        fV.Numerator *= -1;
                    }

                    if (denominatorB)
                    {
                        fV.Denominator *= -1;
                    }
                }

                if (isDownSized) continue;
                return fV;
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


        public static FractionValue operator *(FractionValue fvA, FractionValue fvB)
        {
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
