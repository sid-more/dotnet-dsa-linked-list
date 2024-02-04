namespace LinkedList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stack myStack = new Stack();

            // Push elements onto the stack
            myStack.Push(3);
            myStack.Push(7);
            myStack.Push(12);
            myStack.Push(5);

            // Display the stack
            Console.WriteLine("Stack elements:");
            myStack.Display();

            // Pop an element from the stack
            int poppedElement = myStack.Pop();
            Console.WriteLine($"Popped element: {poppedElement}");

            // Display the stack after popping
            Console.WriteLine("Stack elements after popping:");
            myStack.Display();
        }
    }
}