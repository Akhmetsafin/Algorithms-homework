using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03_Algorithms
{
    public struct StrucutrFloat
    {
        {
        public float X { get; set; }
        public float Y { get; set; }

        public StrucutrFloat(float x, float y)
        {
            X = x;
            Y = y;
        }
        public void RunStructFloat()
        {
            Console.WriteLine("================== StrucutrFloat");
            int n = 10;
            int k = 10;
            float[] mas = new float[n];
            Random r = new Random(); // объявление переменной для генерации случ. чисел

            for (int j = 1; j < k; j++)
            {
                var PointFloat_A = new StrucutrFloat(r.Next(1000000), r.Next(1000000));
                var PointFloat_B = new StrucutrFloat(r.Next(1000000), r.Next(1000000));
                mas[j] = (float)Math.Sqrt((PointFloat_A.X + PointFloat_B.X) + (PointFloat_A.Y + PointFloat_B.Y));

            }

        }

    }

}
