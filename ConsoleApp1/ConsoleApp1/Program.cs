namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        CreateStory();
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
}