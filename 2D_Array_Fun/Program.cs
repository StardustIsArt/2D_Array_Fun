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
        const string CHESSBOARD_MODE = "1";
        const string TIC_MODE = "2";
        const string CREATIVE_MODE = "3";
        
        string[] boardTypes = [CHESSBOARD_MODE, TIC_MODE, CREATIVE_MODE];
        Console.WriteLine($"Please select the numerical of which type of grid/board you would like to use: {boardTypes[0]} chessboard, {boardTypes[1]} tic-tac-toe, {boardTypes[2]} or creative mode.\n");
        string chosenBoard = Console.ReadLine();

       
        if (chosenBoard == boardTypes[0])
        {
            Console.WriteLine("\nHow many columns and rows would you like on the chessboard?");
            int chessDimensions = Convert.ToInt32(Console.ReadLine());
            int[] fillerOptions = [1, 2];
            Console.WriteLine($"\nWhat would you like to fill the chessboard with? Enter numerical of choice: {fillerOptions[0]} triangles, {fillerOptions[1]} stars.");
            int chosenFiller = Convert.ToInt32(Console.ReadLine());
            string fillerSymbol;
            
            if (chosenFiller == fillerOptions[0])
            {
                fillerSymbol = "▲";
            }
            else
            {
                fillerSymbol = "*";
            }
            
            int size = chessDimensions;
            char[,] chessboard = new char[size, size];
            for (int row = 0; row < chessDimensions; row++)
            {
                for (int col = 0; col < chessDimensions; col++)
                {
                    chessboard[row, col] = ' ';
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
                    
                    Console.Write($" {fillerSymbol} ");
                
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        if (chosenBoard == boardTypes[1])
        {
            Console.WriteLine("How large would you like the tic-tac-toe board?");
            int size = Convert.ToInt32(Console.ReadLine());
            
            char[,] ticBoard = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    ticBoard[row, col] = ' ';
                }
            }
            
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"{ticBoard[row, col]} ");
                    if (col < size - 1) Console.Write("|");
                }
                Console.WriteLine();
                if (row < size - 1) 
                {
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write("---");
                        if (i < size - 1) Console.Write("+");
                    }
                    Console.WriteLine(); 
                }
            }
            Console.WriteLine();
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
                    grid[r, c] = ' ';
                }
            }
            Console.WriteLine();
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