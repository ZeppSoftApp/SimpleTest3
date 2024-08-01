namespace SimpleTest3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name = string.Empty;
        name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}

