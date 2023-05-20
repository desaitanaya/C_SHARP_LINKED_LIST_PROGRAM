using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    class Stack<T> where T : IComparable<T>
    {
         Node<T> node = new Node<T>();
        public void Push(T data)
        {
            node.InsertNodeEnd(data);
        }

        public void Pop()
        {
            node.DeleteNodeEnd();
        }

        public void DisplayStack()
        {
            node.DisplayNode();
        }
    }

    class StackProgram<T>
    {
        static void main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.DisplayStack();

            stack.Push(20);
            stack.DisplayStack();

            stack.Push(30);
            stack.DisplayStack();

            stack.Pop();
            stack.DisplayStack();


        }
    }
}
