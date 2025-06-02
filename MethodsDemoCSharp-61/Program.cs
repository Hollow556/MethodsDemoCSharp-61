namespace MethodsDemoCSharp_61;

class Program
{
    //Create custom methods here
    
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //string userInput = Console.ReadLine();
        
        //calling the method (using a method)
        //Console.ForegroundColor = ConsoleColor.Blue;
        GreetUserByName("Seth");
        GreetUserByName("Miah");

        double sum = DoubleAddition(2.5, 2.5);
        Console.WriteLine($"Sum: {sum}");
        
        SayHello();
    }
    
    //Or create custom methods here
    
    //method definition (creating a method)
    //access modifier - return type - method name (PascalCase) - parameter list - scope/body
    public static void GreetUserByName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static double DoubleAddition(double numOne, double numTwo)
    {
       //double sum = numOne + numTwo;
       return numOne + numTwo;
    }

    public static void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}