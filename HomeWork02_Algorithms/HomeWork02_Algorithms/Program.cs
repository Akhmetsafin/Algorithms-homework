using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           var numArra = new int[] { 55, 11, 77, 22, 16, 57, 56, 14 };
            Console.Write("Введите искомое число: ");
            int seachNum = Convert.ToInt32(Console.ReadLine());
           Binar binar = new Binar();
           Console.WriteLine( $"число {seachNum} является элементом {binar.BinarySearch(numArra, seachNum)} массива" );
           Console.ReadLine();
        }
    }
}
