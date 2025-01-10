namespace Nr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           =
            Console.Write("Enter the car make: ");
            string make = Console.ReadLine();

            Console.Write("Enter the car model: ");
            string model = Console.ReadLine();

            Console.Write("Enter the car year: ");
            int year = int.Parse(Console.ReadLine());

            =
            Car car = new Car(make, model, year);

           =
            Console.WriteLine($"Car Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
        }
    }
}
