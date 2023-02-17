//Task50
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив: 1 4 7 2  5 9 2 3  8 4 2 4
//17 -> такого числа в массиве нет
//Task50* Заполнить числами Фиббоначи и выделить цветом найденную цифру
using System;
//Console.Clear();
Console.WriteLine("Seminar7. Home task №7");
Console.WriteLine("---Task 47---");
//ввод
int m = ReadData("Enter the number of rows: ");
int n = ReadData("Enter the number of columns: ");
int[,] matrix = CreateTwoDimArray(m, n);
int row = ReadIndex("строки", matrix.GetLength(0));
int column = ReadIndex("столбца", matrix.GetLength(1));

//вывод
Console.WriteLine("Сгенерированная матрица: ");
PrintTwoDimArray(matrix);
Console.WriteLine("Матрица с числом Фибоначчи");
FindValueOfELement();
Console.WriteLine("Последовательность Фибоначчи");

///=============================Методы========================================
//-М- метода задания строки
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
            outArray[i, j] = numberSymtezator.Next(0, 11);
            j++;
        }
        i++;
    }
    return outArray;
}

//Метод ввода индексов
int ReadIndex(string dimension, int length)
{
    int index;
    bool indexIsValid = false; //  метод для проверка валидности введеного элемента

    do
    {
        Console.WriteLine($"Введите индекс {dimension} (0-index):");
        string input = Console.ReadLine() ?? "0";
        indexIsValid = int.TryParse(input, out index) && index >= 0 && index < length;

        if (!indexIsValid)
        {
            Console.WriteLine($"Диапазон индексов {dimension} не действительный. Введите новый между 0 и {length - 1}.");
        }
    } while (!indexIsValid);

    return index;
}

// //-М- вывод на печать двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " \t");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

//-М- метод поиска элемента по его индексам в массиве
void FindValueOfELement()
{
    //FillWithFibonacci(matrix);

    if (row < 0 || row >= matrix.GetLength(0) || column < 0 || column >= matrix.GetLength(1))
    {
        Console.WriteLine("Нет такого элемента в строке.");
    }
    else
    {
        PrintMatrixWithHighlight(matrix, row, column, ConsoleColor.Green);
    }
}

//-М- метод печати найденного элемента в массиве цветом
void PrintMatrixWithHighlight(int[,] matrix, int rowIndex, int columnIndex, ConsoleColor color)
{
    int r = matrix.GetLength(0);
    int c = matrix.GetLength(1);

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            if (i == rowIndex && j == columnIndex)
            {
                Console.ForegroundColor = color;
                //result = (matrix[i, j]);
                int result = GenerateFibonacciList(matrix[i, j]);
                Console.Write($"{result}");
                Console.ResetColor();
                Console.Write("\t");

            }
            else
            {
                Console.Write($"{matrix[i, j],-5}" + " \t");
            }
        }
        Console.WriteLine();
    }
}

//-М- метод расчет суммы чисел из последовательности Фибоначчи 
int GenerateFibonacciList(int limit)
{
    List<int> fibonacciList = new List<int>();
    int prev = 0, curr = 1;
    fibonacciList.Add(0);
    fibonacciList.Add(1);
    int summFibonacci = 0;
    while (prev + curr <= limit)
    {
        int next = prev + curr;
        fibonacciList.Add(next);
        prev = curr;
        curr = next;
    }
    //int[] fibonacciArray = fibonacciList.ToArray();
    foreach (int sum in fibonacciList)
    {
        summFibonacci += sum;
    }
    return summFibonacci;
}

