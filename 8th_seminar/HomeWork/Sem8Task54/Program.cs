// Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив: 1 4 7 2 -- 5 9 2 3 -- 8 4 2 4
// В итоге получается вот такой массив: 7 4 2 1 -- 9 5 3 2 -- 8 4 4 2
Console.Clear();
Console.WriteLine("Seminar8. Home task №8");
Console.WriteLine("---Task 54---");

//int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int m = ReadData("Enter the number of rows: ");
int n = ReadData("Enter the number of columns: ");

Console.WriteLine("Сгенерированная матрица: ");
int[,] array = CreateTwoDimArray(m,n);
PrintTwoDimArray(array);
Console.WriteLine("Отсортировання матрица: ");
PrintTwoDimArray(SortRowsDescending(array));

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

//-М- метод упорядочивания позиций в массиве 
int[,] SortRowsDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] row = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i, j];
        }
        Array.Sort(row);
        Array.Reverse(row);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = row[j];
        }
    }
    return array;
}
