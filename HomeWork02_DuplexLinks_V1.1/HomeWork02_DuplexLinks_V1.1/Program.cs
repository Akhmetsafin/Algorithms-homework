using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02_DuplexLinks_V1._1
{
    class Program
    {



        static void Main(string[] args)
        {
            var node = new Node();
            // ввод данных
            node.AddNode(1);
            node.AddNode(2);
            node.AddNode(3);
            node.AddNodeAfter(node.head.NextNode, 33);


            // вывод данных
            Console.WriteLine(node.head.NextNode.NextNode.Value);
            // кол-во элементов
            Console.WriteLine(node.GetCount());
            // удаление элемента
            node.RemoveNextItem(node.head);
            node.RemoveNode(node.head, 1);
            // кол-во элементов после удаления
            Console.WriteLine(node.GetCount());
            //поиск по значению
            Console.WriteLine(node.FindNode(33) == null ? "Yes" : "OBHKSS");

                Console.ReadLine();
            }
     }
    
}
