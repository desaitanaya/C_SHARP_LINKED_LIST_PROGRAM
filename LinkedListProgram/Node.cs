using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    //Creating a Node in Linked list
    public class Node<T> where T : IComparable<T>
    {
        public T data;
        public Node<T> next;
        public Node<T> head;

        public Node(T x)
        {
            data = x;
            next = null;
        }

        public Node()
        {
        }

        //Method for inserting value at start of the linked list
        public void InsertNodeStart(T data)
        {
            Node<T> newNode = new Node<T>(data);
            //Checking if the linked list is empty
            if (head == null)
            {
                head = newNode;
            }
            //Inserting a new node at the start
            else
            {
                newNode.next = head;
                head = newNode;
            }

        }

        //Method for inserting value at end of the linked list
        public void InsertNodeEnd(T data)
        {
            Node<T> newNode = new Node<T>(data);
            Node<T> temp = head;

            //Checking if the linked list is empty
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                //Inserting a new node at the end
                temp.next = newNode;
            }

        }

        //Method for inserting value at position in linked list
        public void InsertNodePosition(int position, T data)
        {
            Node<T> newNode = new Node<T>(data);
            Node<T> temp = head;
            Node<T> previous = null;

            //Checking if the linked list is empty
            if (head == null)
            {
                return;
            }
            if (position == 1 || head == null)
            {
                InsertNodeStart(data);
                return;
            }
            int index = 1;
            while (temp != null && index < position)
            {
                previous = temp;
                temp = temp.next;
                index++;

            }
            previous.next = newNode;
            newNode.next = temp;
        }

        //Method for deleting value at start of the linked list
        public void DeleteNodeStart()
        {
            //Checking if the linked list is empty
            if (head == null)
            {
                return;
            }
            head = head.next;
        }

        //Method for deleting value at the end of the linked list
        public void DeleteNodeEnd()
        {
            Node<T> temp = head;
            Node<T> previous = null;

            //Checking if the linked list is empty
            if (head == null)
            {
                return;
            }
            else
            {
                //Traversing till the second last node
                while (temp.next != null)
                {
                    previous = temp;
                    temp = temp.next;
                }
                previous.next = null;
            }
        }


        //Method for deleting value at position in linked list
        public void DeleteNodePosition(int position)
        {
            Node<T> temp = head;
            Node<T> previous = null;

            //Checking if the linked list is empty
            if (head == null)
            {
                return;
            }

            if (head == null || position == 1)
            {
                DeleteNodeStart();
                return;
            }
            int index = 1;
            while (temp != null && index < position)
            {
                previous = temp;
                temp = temp.next;
                index++;
            }
            previous.next = temp.next;
        }


        //Method for displaying the linked list
        public void DisplayNode()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }

        }
    }
}
