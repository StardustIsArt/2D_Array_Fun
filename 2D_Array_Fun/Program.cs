using System.Diagnostics;
using System.Drawing;

namespace _2D_Array_Fun;
using System;
using System.Drawing.Icons;
using Console = Colorful.Console;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Let's make a 2D Grid!");
        Console.WriteLine("How many columns would you like in your grid?");
        int columns = int.Parse(Console.ReadLine());
        Console.WriteLine("How many rows would you like in your grid?");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("How would you like to fill the values of your grid? ");
        string values = (Console.ReadLine());
        
        int [,] grid = new int [rows, columns];

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                grid[r, c] = r + c;
            }
        }
        
        Console.WriteLine(grid);
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                Console.Write(grid[r,c] + "\t", Color.DeepPink);
            }
            Console.WriteLine();
        }
       
    }
    
}