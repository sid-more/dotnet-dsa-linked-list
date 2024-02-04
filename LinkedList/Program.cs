namespace LinkedList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();

            // Insert elements with duplicates into the linked list
            myList.Insert(3);
            myList.Insert(7);
            myList.Insert(12);
            myList.Insert(5);
            myList.Insert(7);
            myList.Insert(3);

            // Display the linked list before removing duplicates
            Console.WriteLine("Linked List elements before removing duplicates:");
            myList.Display();

            // Remove duplicates
            myList.RemoveDuplicates();

            // Display the linked list after removing duplicates
            Console.WriteLine("Linked List elements after removing duplicates:");
            myList.Display();
        }
    }
}