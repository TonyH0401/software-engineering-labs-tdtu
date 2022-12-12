using System;
using System.Globalization;

namespace DemoLib
{
   public struct Complex : IEquatable<Complex>, IFormattable
   {
      public static readonly Complex Zero = new Complex(0, 0);
      public static readonly Complex One = new Complex(1, 0);
      public static readonly Complex ImaginaryOne = new Complex(0, 1);

      public double Real { get; }
      public double Imaginary { get; }
      public double Magnitude => Math.Sqrt(Real*Real + Imaginary*Imaginary);
      public double Phase => Math.Atan2(Imaginary, Real);

      public Complex(double r, double i)
      {
         Real = r;
         Imaginary = i;
      }

      public override string ToString() => $"{Real}+{Imaginary}i";

      public bool Equals(Complex other)
      {
         return Real.Equals(other.Real) && Imaginary.Equals(other.Imaginary);
      }

      public override bool Equals(object obj)
      {
         Complex other = (Complex)obj;
         return Real.Equals(other.Real) && Imaginary.Equals(other.Imaginary);
      }

      public override int GetHashCode()
      {
         return Real.GetHashCode() * 13 + Imaginary.GetHashCode();
      }

      public string ToString(string format, IFormatProvider formatProvider)
      {
         if (string.IsNullOrEmpty(format)) format = "S";
         if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

         switch(format.ToUpperInvariant())
         {
            case "S": return $"{Real.ToString("", formatProvider)}+{Imaginary.ToString("", formatProvider)}i";
            case "P": return $"({Real.ToString("", formatProvider)}, {Imaginary.ToString("", formatProvider)})";
            default: throw new FormatException($"The {format} format string is not supported.");
         }
      }

      public static Complex operator +(Complex a, Complex b) =>
         new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
      public static Complex operator -(Complex a, Complex b) =>
         new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
      public static Complex operator *(Complex a, Complex b) =>
         new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary,
                     a.Real * b.Imaginary + a.Imaginary * b.Real);
   }
}
