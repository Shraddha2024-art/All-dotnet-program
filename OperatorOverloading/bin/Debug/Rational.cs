using System;

namespace OperatorOverloading
{
    public class Rational
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            return new Rational(r1.X + r2.X, v1.Y + v2.Y);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector operator *(Vector v, int scalar)
        {
            return new Vector(v.X * scalar, v.Y * scalar);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 3);
            Vector v2 = new Vector(4, 5);

            Console.WriteLine("v1: " + v1);
            Console.WriteLine("v2: " + v2);

            Vector sum = v1 + v2;
            Console.WriteLine("v1 + v2: " + sum);

            Vector difference = v1 - v2;
            Console.WriteLine("v1 - v2: " + difference);

            Vector scaled = v1 * 2;
            Console.WriteLine("v1 * 2: " + scaled);

            Console.ReadLine();
        }
    }
}