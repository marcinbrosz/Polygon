using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    /*
     * This is a collection of methods we expect and require a polygon to have
     */
    interface polygon
    {
        /*number of sides polygon*/
        int getNumberSides();
        /*perimeter of the polygon*/
        double getPerimeter();
    }

    class Triangle : polygon
    {
        private int sides = 3;
        private int side1;
        private int side2;
        private int side3;
        public Triangle(int s1,int s2, int s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public int getNumberSides()
        {
            return sides;
        }

        public double getPerimeter()
        {
            return side1 + side2 + side3;
        }


    }

    class Rectangle : polygon
    {
        private int sides = 4;
        private int side1;
        private int side2;
        public Rectangle(int s1, int s2)
        {
            side1 = s1;
            side2 = s2;
        }

        public int getNumberSides()
        {
            return sides;
        }

        public double getPerimeter()
        {
            return 2*side1 + 2*side2;
        }
        public virtual void testVirtual()
        {
            Console.WriteLine("Triangle");
        }
    }
    class Square : Rectangle
    {
        public Square(int s1) : base(s1, s1) { }
        sealed public override void testVirtual()
        {
            base.testVirtual();
            Console.WriteLine("Square");
        }

    }
    class SquareTest : Square
    {
        public SquareTest(int s1) : base(s1) { }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(2);
            Console.WriteLine(s.getNumberSides());
            Console.WriteLine(s.getPerimeter());
            s.testVirtual();
            Console.ReadLine();
        }
    }
}
