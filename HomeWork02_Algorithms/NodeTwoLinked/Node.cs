using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeTwoLinked
{
    public  class Node
    {
        public Node head;
        public Node tail;

        public int Value { get; set; }
        public Node NextItem { get; set; }
        public Node PrevItem { get; set; }

       

       
        public  void AddItem(Node startNode, int value) //добавление в конец, если не знаем конечный элемент
        {
            var node = startNode;

            while (node.NextItem != null)
            {
                node = node.NextItem;
            }

            var newNode = new Node { Value = value };
            node.NextItem = newNode;
        }
        public  void AddItemEnd(Node start, int value) //добавление в конец, если не знаем конечный элемент
        {
            var node = start;

            while (node.PrevItem != null)
            {
                node = node.NextItem;
            }

            var newNode = new Node { Value = value };
            node.NextItem = newNode;
        }


    }
}
