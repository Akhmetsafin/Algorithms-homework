using BenchmarkDotNet.Attributes;
using System;

namespace benchmarkdotnet_V1._2
{

    public class Point
    {
        public Point()
        {
        }
        public float X { get; set; }
        public float Y { get; set; }
        public Point(float x, float y)
        {
            X = x;

            Y = y;
        }
        [Benchmark]

        public void RunClass()
        {
            Console.WriteLine("================== class");
            //int n = 10;
            int k = 10;//количество итераций цикла
            //double[,] mas = new double [n,n];
            Random r = new Random(); // объявление переменной для генерации случ. чисел

            for (int j = 1; j < k; j++)
            {
                var A_Class = new Point(r.Next(1000000), r.Next(1000000));
                var B_Class = new Point(r.Next(1000000), r.Next(1000000));
                MathClass(A_Class, B_Class);
            }

        }

        public void MathClass(Point a, Point b)
        {

            double rastoyanie = Math.Sqrt((a.X + b.X) + (a.Y + b.Y));
            Console.WriteLine(rastoyanie);
            ///return rastoyanie;
        }
    }
    

}
