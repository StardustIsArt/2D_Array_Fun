namespace _2D_Array_Fun;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Let's make a 2D Grid!");
        Console.WriteLine("How many columns would you like in your grid?");
        int columns = int.Parse(Console.ReadLine());
        Console.WriteLine("How many rows would you like in your grid?");
        int rows = int.Parse(Console.ReadLine());
        int [,] grid = new int [columns, rows];
        
    }
}