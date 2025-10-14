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
        int filler = 0;
        int [,] grid = new int [rows, columns];

        for (int i = 0; i < columns; i++)
        {
            grid[rows, i] = filler;
        }

        for (int j = 0; j < rows; j++)
        {
            grid[j, columns] = filler;
        }
        
       
    }
    
}