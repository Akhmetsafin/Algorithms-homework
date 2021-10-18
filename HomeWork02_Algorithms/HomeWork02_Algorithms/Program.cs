using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublyLinkedList
{
    class Program : NodeDuplex

    // нахожусь в дороге, задание выполнить в срок не успею, сделаю к сле
    {
        public static void Main(string[] args)
        {
            NodeDuplex nodeDuplex = new NodeDuplex();
            nodeDuplex.AddNode(12);
            Console.WriteLine(nodeDuplex.GetCount());
            Console.WriteLine();
        }
    }

    /*
     var numArra = new int[] { 11, 55,56,77 };
            Console.Write("Введите искомое число: ");
            int seachNum = Convert.ToInt32(Console.ReadLine());
           Binar binar = new Binar();
            int numMy = binar.BinarySearch(numArra, seachNum);
           Console.WriteLine( $"число {seachNum} является элементом {numMy} массива" );
           Console.ReadLine();
     */
}
