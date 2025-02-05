namespace Topic_2_Numbers_and_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the amount of money you would make if you earned $21/hr for 8 hours:");
            Console.WriteLine(21 * 8);
            Console.WriteLine("");
            Console.WriteLine("Here is the amount it would cost to get a dozen eggs:");
            Console.WriteLine(6 * 12);
            Console.WriteLine("");
            Console.WriteLine("The tax on $79.99 is " + (79.88 * 0.13).ToString("C"));
            Console.WriteLine("");
            Console.WriteLine("There are " + (5 * 12 + 6) * 2.54 + " centimeters in 5'6\"");
        }
    }
}
