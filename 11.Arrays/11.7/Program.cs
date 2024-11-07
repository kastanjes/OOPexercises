using System;

public class Sudoku15 
{
    private int[,] board; // Use a 2D array to represent the Sudoku board

    public Sudoku15() 
    {
        board = new int[15, 15]; // Initialize a 15x15 grid
    }

    // Method to set a value in a cell
    public void SetCellValue(int row, int col, int value) 
    {
        if (row >= 0 && row < 15 && col >= 0 && col < 15 && value >= 0 && value <= 15) 
        {
            board[row, col] = value;
        } 
        else 
        {
            Console.WriteLine("Invalid cell position or value");
        }
    }

    // Method to get a value from a cell
    public int GetCellValue(int row, int col) 
    {
        if (row >= 0 && row < 15 && col >= 0 && col < 15) 
        {
            return board[row, col];
        } 
        else 
        {
            Console.WriteLine("Invalid cell position");
            return -1;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of Sudoku15
        Sudoku15 sudoku = new Sudoku15();
        
        // Set and get an example cell value
        sudoku.SetCellValue(0, 0, 5);
        Console.WriteLine("Value at (0, 0): " + sudoku.GetCellValue(0, 0));
        
        // Additional example: Set and get another cell value
        sudoku.SetCellValue(1, 1, 10);
        Console.WriteLine("Value at (1, 1): " + sudoku.GetCellValue(1, 1));
    }
}
