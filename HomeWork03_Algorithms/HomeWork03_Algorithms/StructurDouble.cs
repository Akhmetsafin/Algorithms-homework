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
                var StructurDouble_A = new StructurDouble(r.Next(1000000), r.Next(1000000));
                var StructurDouble_B = new StructurDouble(r.Next(1000000), r.Next(1000000));
                mas[j] = Math.Sqrt((StructurDouble_A.X + StructurDouble_B.X) + (StructurDouble_A.Y + StructurDouble_B.Y));
                Console.WriteLine(mas[j]);
            }

        }
    }
}
