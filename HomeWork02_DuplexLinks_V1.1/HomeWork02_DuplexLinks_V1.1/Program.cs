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
                    node.AddNode(1);
                    node.AddNode(2);
                    node.AddNode(3);
                    node.AddNodeAfter(node.head.NextNode, 33);

                   

            Console.WriteLine(node.head.NextNode.NextNode.Value);

                Console.WriteLine(node.GetCount());

               node.RemoveNode(node.head,1);
               node.RemoveNode(node.head,1);

                Console.WriteLine(node.GetCount());
                Console.WriteLine();

                Console.ReadLine();
            }
     }
    
}
