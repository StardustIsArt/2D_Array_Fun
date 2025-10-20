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
        const string CREATIVE_MODE = "creative";
        const string CHESSBOARD_MODE = "chessboard";
        const string TIC_MODE = "tic-tac-toe";
        
        string[] boardTypes = [CHESSBOARD_MODE, TIC_MODE, CREATIVE_MODE];
        Console.WriteLine($"Please select which type of grid/board you would like to use: {boardTypes[0]}, {boardTypes[1]}, {boardTypes[2]}.\n");
        string chosenBoard = Console.ReadLine();

        if (chosenBoard == boardTypes[0])
        {
            Console.WriteLine("\nHow many columns and rows would you like on the chessboard?");
            int chessDimensions = Convert.ToInt32(Console.ReadLine());
            string[] fillerOptions = ["triangles", "stars"];
            Console.WriteLine($"\nWhat would you like to fill the chessboard with? {fillerOptions[0]}, {fillerOptions[1]}.");
            string chosenFiller = Console.ReadLine();
            
            int size = chessDimensions;
            string[,] chessboard = new string[size, size];
            for (int row = 0; row < chessDimensions; row++)
            {
                for (int col = 0; col < chessDimensions; col++)
                {
                    chessboard[row, col] = " ";
                }
            }
            
            for (int row = 0; row < chessDimensions; row++) {
                
                for (int column = 0; column < chessDimensions; column++)
                {
                    bool darkSpace = (row + column)  % 2 == 0;
                    Color bgColor;
                    Color fgColor;
                    if (darkSpace)
                    {
                        bgColor = Color.CadetBlue;
                        fgColor = Color.White;
                    }
                    else
                    {
                        bgColor = Color.White;
                        fgColor = Color.CadetBlue;
                    }
                   
                    Console.BackgroundColor = bgColor;
                    Console.ForegroundColor = fgColor;
                    
                    Console.Write($" {chosenFiller}{row}{column}");
                
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        if (chosenBoard == boardTypes[1])
        {
            Console.WriteLine("\nHow large would you like the tic-tac-toe board?");
            string ticDimensions = Console.ReadLine();
        }

        if (chosenBoard == boardTypes[2])
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