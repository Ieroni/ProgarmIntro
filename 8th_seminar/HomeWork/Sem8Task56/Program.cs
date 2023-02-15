// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив: // 1 4 7 2 -- 5 9 2 3 -- 8 4 2 4 -- 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
Console.WriteLine("Seminar8. Home task №8");
Console.WriteLine("---Task 56---");

//Ввод
int m = ReadData("Enter the number of rows: ");
int n = ReadData("Enter the number of columns: ");

//Вывод
Console.WriteLine("Сгенерированная матрица: ");
int[,] array = CreateTwoDimArray(m,n);
PrintTwoDimArray(array);
Console.WriteLine("номер строки с наименьшей суммой элементов: " + (FindRowWithSmallestSum(array)+1));



///=============================Методы========================================
//-М- метода генерации 2умерного случайного массива
int ReadData(string msg)
{
    Console.WriteLine(msg);
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

//-М- метод поиска строки с наименьшей семмой 0элементов
int FindRowWithSmallestSum(int[,] array)
{
    Console.WriteLine();
    int smallestSum = int.MaxValue;
    int smallestSumRow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        if (rowSum < smallestSum)
        {
            smallestSum = rowSum;
            smallestSumRow = i;
        }
        Console.WriteLine("сумма строки " + (i+1) + ": " + rowSum);
    }
    Console.WriteLine();
    return smallestSumRow;
}


