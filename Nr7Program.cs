namespace Nr7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product("Laptop", 999.99);


            Console.WriteLine($"Product Name: {product.Name}");
            Console.WriteLine($"Product Price: ${product.Price}");

            Console.ReadLine();
        }
    }
}
