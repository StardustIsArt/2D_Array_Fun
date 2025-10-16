using System.Diagnostics;
using System.Drawing;

namespace _2D_Array_Fun;
using System;
using System.Drawing;
using Console = Colorful.Console;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello! Let's make a 2D Grid!");
        
        
        string[] boardTypes = ["chessboard", "tic-tac-toe", "creative"];
        Console.WriteLine($"Please select which type of grid/board you would like to use: {boardTypes[0]}, {boardTypes[1]}, {boardTypes[2]}.\n");
        string chosenBoard = Console.ReadLine();

        if (chosenBoard == "chessboard")
        {
            Console.WriteLine("\nHow many columns and rows would you like on the chessboard?");
            string chessDimensions = Console.ReadLine();
        }

        if (chosenBoard == "ticTacToe")
        {
            Console.WriteLine("\nHow large would you like the tic-tac-toe board?");
            string ticDimensions = Console.ReadLine();
        }

        if (chosenBoard == "creative")
        {
            Console.WriteLine("\nHow many columns would you like in your grid?");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine("How many rows would you like in your grid?");
            int rows = int.Parse(Console.ReadLine());
            
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
        
       // Console.WriteLine("How would you like to fill the values of your grid? ");
       // string values = (Console.ReadLine());
        
        
        
        
       
    }
    
}