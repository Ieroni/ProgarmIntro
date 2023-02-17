//Task52
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив: 1 4 7 2   5 9 2 3  8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Task52* Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.
using System;
Console.Clear();
Console.WriteLine("Seminar7. Home task №7");
Console.WriteLine("---Task 52---");

//ввод
int m = ReadData("Enter the number of rows: ");
int n = ReadData("Enter the number of columns: ");

//вывод
Console.WriteLine("Сгенерированная матрица: ");
int[,] matrix = CreateTwoDimArray(m, n);
PrintTwoDimArray(matrix);
MeanOfColumns(matrix);

///=============================Методы========================================
//-М- метода генерации 2умерного случайного массива
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//-М- метода генерации 2умерного случайного массива
int[,] CreateTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSymtezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSymtezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

//-М- вывод на печать двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    Random random = new Random();
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            if (i == j)
            {
                Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0, 16));
                Console.Write(inputArray[i, j] + " \t");
                Console.ResetColor();
            }
            else
            { Console.Write(inputArray[i, j] + " \t"); }
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

//-М- метод расчета среднего арифметического
void MeanOfColumns(int[,] inputArray)
{
    double sum1 = 0, sum2 = 0;
    Console.WriteLine("Среднее арифметическое для каждого столбца: ");
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            sum += inputArray[i, j];
        }
        double mean = sum / inputArray.GetLength(0);
        Console.WriteLine(mean.ToString("0.0"));
    }
    int minDim = Math.Min(inputArray.GetLength(0), inputArray.GetLength(1));
    {
        for (int i = 0; i < minDim; i++)
        {
            sum1 += inputArray[i, i];
            sum2 += inputArray[i, minDim - i - 1];
        }
    }

    double mean1 = sum1 / minDim;
    double mean2 = sum2 / minDim;
    Console.WriteLine("Среднее арифметическое 1ой диагонали: " + mean1.ToString("0.0"));
    Console.WriteLine("Среднее арифметическое 2ой диагонали: " + mean2.ToString("0.0"));
}