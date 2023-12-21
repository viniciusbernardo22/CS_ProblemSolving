namespace printService;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        PrintService<int> printService = new ();

        Console.Write("How many values? ");

        int n = int.Parse(Console.ReadLine());
       
        for (int i = 0; i < n; i++)
        {
            Console.Write($"value {i + 1} is: ");
            int x = int.Parse(Console.ReadLine());
            printService.AddValue(x);

        }

        printService.Print();

        Console.WriteLine($" The first one is: {printService.First()}");

    }
}