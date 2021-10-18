using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeTwoLinked
{
    class Program
    {
        public static void Main(string[] args)
        {
            Node node = new Node();
            ///node.Value=0;
            
          
            for (int i=1; i<13; i++)
            {
                node.AddItem(node, i);
            }

            Console.WriteLine(node.Value);
            Console.WriteLine(node.NextItem.Value);
            Console.WriteLine(node.NextItem.NextItem.Value);
            Console.WriteLine(node.NextItem.NextItem.NextItem.Value);
            Console.WriteLine(node.NextItem.NextItem.NextItem.NextItem.Value);
           



            Console.ReadLine();
        }
        
    }
}
