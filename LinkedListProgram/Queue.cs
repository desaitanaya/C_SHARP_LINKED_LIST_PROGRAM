using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    class Queue<T> where T : IComparable<T>
    {
        Node<T> node = new Node<T>();
        public void Enqueue(T data)
        {
            node.InsertNodeEnd(data);
        }

        public void Dequeue()
        {
            node.DeleteNodeStart();
        }

        public void DisplayStack()
        {
            node.DisplayNode();
        }
    }

    class QueueProgram<T>
    {
        static void main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.DisplayStack();

            queue.Enqueue(20);
            queue.DisplayStack();

            queue.Enqueue(30);
            queue.DisplayStack();

            queue.Dequeue();
            queue.DisplayStack();


        }
    }
}
