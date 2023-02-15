// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
Console.WriteLine("Seminar8. Home task №8");
Console.WriteLine("---Task 62---");

//Ввод
int m = ReadData("введите число строк: ");
int n = ReadData("введите число столбцов: ");
int[,] array = new int[m, n];


//Вывод
Console.WriteLine("Сгенерированная матрица: ");
PrintTwoDimArray(FillHelixArray(array));

///=============================Методы========================================
//-М- метода генерации 2умерного случайного массива
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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

//-М- метод созданяи спиральной матрицы (helix pattern)
int[,] FillHelixArray(int[,] array)
{
    int n = array.GetLength(0);
    int row = 0, col = 0;
    int value = 1;

    while (n > 0)
    {
        if (n == 1)
        {
            array[row, col] = value++;
            break;
        }

        for (int i = 0; i < n - 1; i++)
        {
            array[row, col++] = value++;
        }

        for (int i = 0; i < n - 1; i++)
        {
            array[row++, col] = value++;
        }

        for (int i = 0; i < n - 1; i++)
        {
            array[row, col--] = value++;
        }

        for (int i = 0; i < n - 1; i++)
        {
            array[row--, col] = value++;
        }

        row++;
        col++;
        n -= 2;
    }
    return array;
}




