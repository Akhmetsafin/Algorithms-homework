using System;

namespace AlgorithmsHoumeWorks
{
    class Simple_number
    {
        string welcom = "Программа определения простых и не простых чисел";
        public void Verification()
        {
            int i = 2;
            int d = 0;
            string value;

            // while (Console.ReadKey(true).Key != ConsoleKey.N)


            //Console.WriteLine("Введите число: ");
            string text = Console.ReadLine();



            if (int.TryParse(text, out int numberInter))

            {
                while (i < numberInter)
                {
                    if (numberInter % i == 0)
                    {
                        i++;
                        d++;
                        continue;
                    }
                    else
                    {
                        i++;
                        continue;
                    }
                }

                {
                    if (d == 0)
                    {
                        value = "это число - простое";
                    }
                    else
                    {
                        value = "это число - не простое";
                    }

                    //Console.ReadLine();
                }
                Console.WriteLine(value);
                Console.WriteLine("продолжить нажмите Enter? выйти нажмите ESC");

            }
            else
            {
                Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
            }






        }
        public void Core()
        {
            do
            {
                Console.WriteLine("Введите число: ");
                Verification();
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

    }
}
