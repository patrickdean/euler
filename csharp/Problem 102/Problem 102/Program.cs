using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem_102
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
            : this()
        {
            X = x;
            Y = y;
        }

        public Point Reverse
        {
            get { return new Point(Y, X); }
        }
    }

    public struct Triangle
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }

        public Triangle(Point p1, Point p2, Point p3)
            : this()
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public Point BiggestY
        {
            get 
            {
                if (P1.Y > P2.Y && P1.Y > P3.Y)
                    return P1;
                else if (P2.Y > P1.Y && P2.Y > P3.Y)
                    return P2;
                else
                    return P3;
            }

        }

        public Point BiggestX
        {
            get
            {
                if (P1.X > P2.X && P1.X > P3.X)
                    return P1;
                else if (P2.X > P1.X && P2.X > P3.X)
                    return P2;
                else
                    return P3;
            }

        }

        public Point SmallestY
        {
            get 
            {
                if (P1.Y < P2.Y && P1.Y < P3.Y)
                    return P1;
                else if (P2.Y < P1.Y && P2.Y < P3.Y)
                    return P2;
                else
                    return P3;
            }
        }

        public Point SmallestX
        {
            get
            {
                if (P1.X < P2.X && P1.X < P3.X)
                    return P1;
                else if (P2.X < P1.X && P2.X < P3.X)
                    return P2;
                else
                    return P3;
            }
        }
        
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();

            Point origin = new Point(0, 0);

            StreamReader file = new StreamReader("triangles.txt");

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] lines = line.Split(',');
                int[] nums = new int[6];

                for (int i = 0; i < 6; i++)
                    nums[i] = int.Parse(lines[i]);

                Point p1 = new Point(nums[0], nums[1]);
                Point p2 = new Point(nums[2], nums[3]);
                Point p3 = new Point(nums[4], nums[5]);

                triangles.Add(new Triangle(p1, p2, p3));

            }
            int count = 0;

            foreach (Triangle t in triangles)
            {
                count += IsInside(origin, t.SmallestY, t.BiggestY) && IsInside(origin, t.SmallestX.Reverse, t.BiggestX.Reverse) ? 1 : 0;
                //Console.WriteLine(IsInside(origin, t.SmallestY, t.BiggestY));
            }

            Console.WriteLine("The count is: " + count);
            Console.Read();
        }


        public static bool IsInside(Point p, Point a, Point b)
        {
            if (p.Y < a.Y || p.Y > b.Y)
                return false;
            //else if (p.X > Math.Max(a.X, b.X))
            //    return false;
            else
            {
                //if (p.X < Math.Min(a.X, b.X))
                //    return true;
                //else
                {
                    double m_red = 0D;

                    if (a.X != b.X)
                        m_red = (double)(b.Y - a.Y) / (double)(b.X - a.X);
                    else
                        m_red = double.PositiveInfinity;

                    double m_blue = 0D;
                    
                    if (a.X != p.X)
                        m_blue = (double)(p.Y - a.Y) / (double)(p.X - a.X);
                    else
                        m_blue = double.PositiveInfinity;

                    if (m_blue >= m_red)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
