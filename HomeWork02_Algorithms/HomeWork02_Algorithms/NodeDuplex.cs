using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublyLinkedList
{
    public  class NodeDuplex
    {
        public NodeDuplex head;
        public NodeDuplex tail;

        public int Value { get; set; }
        public NodeDuplex NextNode { get; set; }
        public NodeDuplex PrevNode { get; set; }

        public interface ILinkedList
        {
            int GetCount(); //Кол-во элементов в списке
            void AddNode(int value); // добавляет 
            void AddNodeAfter(NodeDuplex node, int value); // добавляет  списка после текущего элемента
            void RemoveNode(int index); // удаляет по порядковому номеру
            void RemoveNode(NodeDuplex node); // удаляет указанный элемент
            NodeDuplex FindNode(int searchValue); // поиск элемента по его значению

        }
        public int GetCount()
        {
            int count = 0;
            var node = head;

            while (node != null)
            {
                node = node.NextNode;
                count++;
            }
            return count;
        }
        public void AddNode(int value)
        {
            var newNode = new NodeDuplex { Value = value };

            if (tail == null)
            {
                newNode.NextNode = null;
                newNode.PrevNode = null;
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.NextNode = newNode;
                newNode.PrevNode = tail;
                tail = newNode;
            }
        }

    }
}
