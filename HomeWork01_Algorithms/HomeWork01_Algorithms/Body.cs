using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01_Algorithms
{
    class Body
    {
        
        public int i = 2;
        public int d = 0;
        public string value;

        public void  Verification()
          {
            while (true)
            {
                Console.Write("Введите число: ");
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
                            value = "простое";
                        }
                        else
                        {
                            value = "не простое";
                        }
                    }
                    Console.WriteLine(value);
                    
                    Verification();
                }
                Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
            }





          
        }

            
    }
}
