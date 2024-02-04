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

    class Stack
    {
        private Node top;

        public Stack()
        {
            top = null!;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int data = top.Data;
            top = top.Next;
            return data;
        }

        public void Display()
        {
            Node current = top;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}