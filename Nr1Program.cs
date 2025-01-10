namespace Nr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.Write("Please enter a valid non-negative age: ");
            }

            
            Person person = new Person(name, age);

           
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            
            Console.Write("Enter a new age: ");
            int newAge;
            while (!int.TryParse(Console.ReadLine(), out newAge) || newAge < 0)
            {
                Console.Write("Please enter a valid non-negative age: ");
            }
            person.Age = newAge;

            
            Console.WriteLine($"Updated Name: {person.Name}, Updated Age: {person.Age}");
        }
}
