namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        CreateStory();
        arithmaticSim();
    }

    static void CreateStory()
    {
        Console.Write("Please enter your first name: ");
        string userName = Console.ReadLine();

        Console.Write("Please enter your favorite color: ");
        string favColor = Console.ReadLine();

        Console.Write("What is the animal that suits you the most?: ");
        string animal = Console.ReadLine();

        Console.Write("What is your favorite place on earth?: ");
        string place = Console.ReadLine();
        
        Console.WriteLine($"{userName}'s {animal} is {favColor} and lives in {place}.");
    }

    static void arithmaticSim()
    {
        Console.WriteLine(Add(2, 4));
        Console.WriteLine(Multiply(3, 5));
        Console.WriteLine(Divide(24, 2));
        Console.WriteLine(Subtract(3, 5));
        
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}