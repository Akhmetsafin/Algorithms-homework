using System;


namespace HomeWork03_Algorithms
{
    public struct StrucutrFloat
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
                var StrucutrFloat_A = new StrucutrFloat(r.Next(1000000), r.Next(1000000));
                var StrucutrFloat_B = new StrucutrFloat(r.Next(1000000), r.Next(1000000));
                mas[j] = (float)Math.Sqrt((StrucutrFloat_A.X + StrucutrFloat_B.X) + (StrucutrFloat_A.Y + StrucutrFloat_B.Y));
                Console.WriteLine(mas[j]);
            }

        }

    }
    public struct StrucutrFloatNoSqrt
    {

        public float X { get; set; }
        public float Y { get; set; }

        public StrucutrFloatNoSqrt(float x, float y)
        {
            X = x;
            Y = y;
        }
        public void RunStructFloatNoSqrt()
        {
            Console.WriteLine("================== RunStructFloatNoSqrt");
            int n = 10;
            int k = 10;
            float[] mas = new float[n];
            Random r = new Random(); // объявление переменной для генерации случ. чисел

            for (int j = 1; j < k; j++)
            {
                var StrucutrFloatNoSqrt_A = new StrucutrFloatNoSqrt(r.Next(1000000), r.Next(1000000));
                var StrucutrFloatNoSqrt_B = new StrucutrFloatNoSqrt(r.Next(1000000), r.Next(1000000));
                mas[j] = (float)((StrucutrFloatNoSqrt_A.X + StrucutrFloatNoSqrt_B.X) + (StrucutrFloatNoSqrt_A.Y + StrucutrFloatNoSqrt_B.Y));
                Console.WriteLine(mas[j]);
            }

        }

    }

}
