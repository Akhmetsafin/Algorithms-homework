using System;
using BenchmarkDotNet.Attributes;


namespace benchmarkdotnet_V1._2
{
   public struct StructurFloat
    {
        public float X { get; set; }
        public float Y { get; set; }
        public StructurFloat(float x, float y)
        {
            X = x;
            Y = y;
        }
        public void RunStructFloat()
        {
            Console.WriteLine("================== struct");
            //int n = 10;
            int k = 10;
            //double[,] mas = new double [n,n];
            Random r = new Random(); // объявление переменной для генерации случ. чисел

            for (int j = 1; j < k; j++)
            {
                var A_Struct = new StructurFloat(r.Next(1000000), r.Next(1000000));
                var B_Struct = new StructurFloat(r.Next(1000000), r.Next(1000000));
                MathStruct(A_Struct, B_Struct);
            }

        }

        public void MathStruct(StructurFloat a, StructurFloat b)
        {

            double rastoyanie = Math.Sqrt((a.X + b.X) + (a.Y + b.Y));
            Console.WriteLine(rastoyanie);
            ///return rastoyanie;
        }
    
    }
}
