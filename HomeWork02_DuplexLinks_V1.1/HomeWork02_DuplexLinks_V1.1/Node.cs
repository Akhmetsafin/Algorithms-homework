using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02_DuplexLinks_V1._1
{
    public class Node
    {
        public Node head;
        public Node tail;

        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

        public interface ILinkedList
        {
            int GetCount(); //Кол-во элементов в списке
            void AddNode(int value); // добавляет 
            void AddNodeAfter(Node node, int value); // добавляет  списка после текущего элемента
            void RemoveNode(int index); // удаляет по порядковому номеру
            void RemoveNode(Node node); // удаляет указанный элемент
            Node FindNode(int searchValue); // поиск элемента по его значению

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
            var newNode = new Node { Value = value };

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
        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node { Value = value };

            if (node == null)
                return;

            if (node.NextNode == null)
            {
                node.NextNode = newNode;
                newNode.PrevNode = node;
                newNode.NextNode = null;
                tail = newNode;
            }
            else
            {
                var nextNode = node.NextNode;
                node.NextNode = newNode;
                newNode.NextNode = nextNode;

                node.NextNode.NextNode.PrevNode = newNode;
                newNode.PrevNode = node;
            }
        }

        public  Node RemoveNode(Node node, int index)
        {

            if (index == 0)
            {
                var newNode = node.NextNode;
                node.NextNode = null;
                return newNode;
            }

            int currentIndex = 0;
            var currentNode = node;
            while (currentNode != null)
            {
                if (currentIndex == index - 1)
                {
                    RemoveNextItem(currentNode);
                    return node;
                }

                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            return node;
        }
        public static void RemoveNextItem(Node node) //удаление следующего примера
        {
            if (node.NextNode == null)
                return;

            var nextItem = node.NextNode.NextNode;
            node.NextNode = nextItem;
        }







    }
}
