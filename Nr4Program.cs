namespace Nr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

           
            Circle circle = new Circle(radius);

            
            circle.DisplayInfo();
        }
}
