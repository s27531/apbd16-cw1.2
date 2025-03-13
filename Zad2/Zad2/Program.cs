internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==================");
        Console.WriteLine("Very good program:");
        Console.WriteLine("==================");
        Console.WriteLine($"Sum: 2 + 2 = {Add(2, 2)}");
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
}