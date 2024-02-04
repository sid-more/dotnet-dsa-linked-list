namespace LinkedList
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null!;
        }
    }

    class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null!;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void RemoveDuplicates()
        {
            HashSet<int> uniqueElements = new HashSet<int>();
            Node current = head;
            Node previous = null!;

            while (current != null)
            {
                if (uniqueElements.Contains(current.Data))
                {
                    // Remove duplicate by adjusting pointers
                    previous.Next = current.Next;
                }
                else
                {
                    uniqueElements.Add(current.Data);
                    previous = current;
                }

                current = current.Next;
            }
        }

        public void Display()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }

}