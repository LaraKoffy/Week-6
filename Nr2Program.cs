namespace Nr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the book author: ");
            string author = Console.ReadLine();

           
            Book book = new Book(title, author);

            
            Console.WriteLine($"Book Title: {book.Title}, Author: {book.Author}");
        }
    }
}
