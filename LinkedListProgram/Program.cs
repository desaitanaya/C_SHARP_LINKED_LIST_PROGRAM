namespace LinkedList
{
    //Creating a Node in Linked list
    public class Node
    {
        public int data;
        public Node next;
        public Node head;

        public Node(int x)
        {
            data = x;
            next = null;
        }

        public Node()
        {
        }

        //Method for inserting value at start of the linked list
        public void InsertNodeStart(int data)
        {
            Node newNode = new Node(data);
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
        public void InsertNodeEnd(int data)
        {
            Node newNode = new Node(data);
            Node temp = head;

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
        public void InsertNodePosition(int position, int data)
        {
            Node newNode = new Node(data);
            Node temp = head;

            //Checking if the linked list is empty
            if (head == null)
            {
                return;
            }
            else
            {
                //Checking for the position in linked list and then inserting the new node
                for (int index = 0; index < position - 1; index++)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                temp = temp.next;
            }
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

        //Method for displaying the linked list
        public void DisplayNode()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node();

            node.InsertNodeStart(10);
            node.DisplayNode();
            Console.WriteLine();

            node.InsertNodeStart(20);
            node.DisplayNode();
            Console.WriteLine();

            node.InsertNodeEnd(30);
            node.DisplayNode();
            Console.WriteLine();

            node.InsertNodePosition(2, 15);
            node.DisplayNode();
            Console.WriteLine();

            node.DeleteNodeStart();
            node.DisplayNode();

        }
    }
}
