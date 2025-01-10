
namespace Nr5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 10;


            Console.WriteLine("Original value of number: " + number);


            ModifyByValue(number);
            Console.WriteLine("After ModifyByValue: " + number);


            ModifyByReference(ref number);
            Console.WriteLine("After ModifyByReference: " + number);
        }


        static void ModifyByValue(int value)
        {
            value = 100;
            Console.WriteLine("Inside ModifyByValue: " + value);
        }

      
        static void ModifyByReference(ref int value)
        {
            value = 200; -
            Console.WriteLine("Inside ModifyByReference: " + value);
        }
    }
}
