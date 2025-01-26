namespace Task_30_12_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of small carpets: ");
            int smallCarpetsNumber = int.Parse(Console.ReadLine()!);
            Console.Write("Number of large carpets: ");
            int largeCarpetsNumber = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Price per small carpet is $25");
            Console.WriteLine("Price per small carpet is $35");

            int cost = smallCarpetsNumber * 25 + largeCarpetsNumber * 35;
            double tax = cost * 0.06;

            Console.WriteLine($"Cost: {cost}");
            Console.WriteLine($"Tax: {tax}");

            Console.WriteLine("=========================");

            int offerValidDays = 30;

            Console.WriteLine($"Total estimate: {cost + tax}");
            Console.WriteLine($"This estimate is valid for {offerValidDays} days");
        }
    }
}