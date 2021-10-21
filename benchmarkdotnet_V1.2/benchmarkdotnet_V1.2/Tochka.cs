using System;
using BenchmarkDotNet.Attributes;

namespace benchmarkdotnet_V1._2
{
    public struct Tochka
    {

        public double X { get; set; }
        public double Y { get; set; }
        public Tochka(double x, double y)
        {
            X = x;
            Y = y;
        }
        /*

          public void RunStruct()
          {
              Console.WriteLine("================== struct");
              //int n = 10;
              int k = 10;
              //double[,] mas = new double [n,n];
              Random r = new Random(); // объявление переменной для генерации случ. чисел

              for (int j = 1; j < k; j++)
              {
                  var A_Struct = new Tochka(r.Next(1000000), r.Next(1000000));
                  var B_Struct = new Tochka(r.Next(1000000), r.Next(1000000));
                  MathStruct(A_Struct, B_Struct);
              }

          }

           void MathStruct(Tochka a, Tochka b)
          {

               double rastoyanie = Math.Sqrt((a.X + b.X) + (a.Y + b.Y));
              Console.WriteLine(rastoyanie);
              ///return rastoyanie;
          }
      }*/







        public void RunStruct()
        {
            Console.WriteLine("================== struct");
            int n = 10;
            int k = 10;
            double[] mas = new double[n];
            Random r = new Random(); // объявление переменной для генерации случ. чисел

            for (int j = 0; j < k; j++)
            {
                var A_Struct = new Tochka(r.Next(1000000), r.Next(1000000));
                var B_Struct = new Tochka(r.Next(1000000), r.Next(1000000));
                mas[j] = Math.Sqrt((A_Struct.X + B_Struct.X) + (A_Struct.Y + B_Struct.Y));
                Console.WriteLine(mas[j]);
            }
            //return mas;
        }

    }
}

