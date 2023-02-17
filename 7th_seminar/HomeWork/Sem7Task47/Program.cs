//Task47
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.  0,5 7 -2 -0,2  1 -3,3 8 -9,9  8 7,8 -7,1 9
//* При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
using System;
Console.Clear();
Console.WriteLine("Seminar7. Home task №7");
Console.WriteLine("---Task 47---");
//ввод
int m = ReadData("Enter the number of rows: ");
int n = ReadData("Enter the number of columns: ");
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                        ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};

//вывод
double[,] matrix = CreateTwoDimArray(m, n);
//PrintTwoDimArray(matrix);
Console.WriteLine("Сгенерированная матрица: ");
PrintTwoDimArray(matrix);


///=============================Методы========================================
//-М- метода задания строки
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//-М- метода генерации 2умерного случайного массива
double[,] CreateTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSymtezator = new System.Random();
    int i = 0; int j = 0;
    double[,] outArray = new double[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSymtezator.Next(-10, 11);
            j++;
        }
        i++;
    }
    return outArray;
}

//-М- вывод на печать двумерного массива
void PrintTwoDimArray(double[,] inputArray)
{
    int i = 0;
    Random random = new Random();
    List<int> digitsList = new List<int>();
    while (i < inputArray.GetLength(0))
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            ColoredEachDigits(matrix[i, j]);
        }
        Console.WriteLine();
        i++;
    }
}

//-М- метод покраски каждого симовола внутри вещественного числа
void ColoredEachDigits(double arrayElemet)
{
    char[] digitColor = arrayElemet.ToString("0.0").ToCharArray(); ;
    foreach (char digits in digitColor)
    {
        Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0, 16));
        Console.Write(digits);
        Console.ResetColor();
    }
    Console.Write("\t");
}