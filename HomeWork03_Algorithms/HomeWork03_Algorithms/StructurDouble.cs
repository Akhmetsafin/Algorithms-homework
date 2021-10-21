using System;

namespace HomeWork03_Algorithms
{
    public struct StructurDouble
    {
        public double X { get; set; }
        public double Y { get; set; }
        public StructurDouble(double x, double y)
        {
            X = x;
            Y = y;
        }
        public void RunStructFloat()
        {
            Console.WriteLine("================== PointDouble");
            int n = 10;
            int k = 10;
            double[] mas = new double[n];
            Random r = new Random(); // объявление переменной для генерации случ. чисел

            for (int j = 1; j < k; j++)
            {
                var PointFloat_A = new StructurDouble(r.Next(1000000), r.Next(1000000));
                var PointFloat_B = new StructurDouble(r.Next(1000000), r.Next(1000000));
                mas[j] = Math.Sqrt((PointFloat_A.X + PointFloat_B.X) + (PointFloat_A.Y + PointFloat_B.Y));

            }

        }
    }
}
