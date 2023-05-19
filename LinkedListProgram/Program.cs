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
            node.InsertNodeStart(20);

            node.DisplayNode();

        }
    }
}
