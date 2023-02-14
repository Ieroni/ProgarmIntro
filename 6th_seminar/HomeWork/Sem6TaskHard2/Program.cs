//Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
//Вывести на экран красивенько таблицей. 
//Найти минимальное число и его индекс, найти максимальное число и его индекс. 
//Вывести эту информацию на экран. Попробовать найти медиану и вывести на экран.
//Task Hard 1

//Ввод
int m = ReadData("Enter the number of rows: ");
int n = ReadData("Enter the number of columns: ");

//Вывод
PrintTwoDimArray(CreateTwoDimArray(m, n));
FIndMatrixIndexes(CreateTwoDimArray(m, n));
int median = FindMedian(CreateTwoDimArray(m, n));
Console.WriteLine("Median of the array is: " + median);


///=============================Методы========================================
//-М- метода генерации 2умерного случайного массива
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

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
    Console.WriteLine("Сгенерированная матрица: ");
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

//-М- Метод поиска индексов массива
void FIndMatrixIndexes(int[,] array)
{
    int min = int.MaxValue;
    int max = int.MinValue;
    int minIndexRow = 0;
    int minIndexCol = 0;
    int maxIndexRow = 0;
    int maxIndexCol = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minIndexRow = i;
                minIndexCol = j;
            }
            if (array[i, j] > max)
            {
                max = array[i, j];
                maxIndexRow = i;
                maxIndexCol = j;
            }
        }
    }

    Console.WriteLine("\nResults: ");
    Console.WriteLine("+------------+------------+----------------+");
    Console.WriteLine("|  Property  |  Value     |    Location    |");
    Console.WriteLine("+------------+------------+----------------+");
    Console.WriteLine("|  Minimum   |  {0,3}       |    [{1,2},{2,2}]     |", min, minIndexRow, minIndexCol);
    Console.WriteLine("+------------+------------+----------------+");
    Console.WriteLine("|  Maximum   |   {0,3}      |    [{1,2},{2,2}]     |", max, maxIndexRow, maxIndexCol);
    Console.WriteLine("+------------+------------+----------------+");
}

//-М- Метод для расчета медианы
int FindMedian(int[,] arr)
{
    int[] flattenedArray = FlattenArray(arr);
    Array.Sort(flattenedArray);
    int n = flattenedArray.Length;
    int median;
    if (n % 2 == 0)
    {
        median = (flattenedArray[n / 2 - 1] + flattenedArray[n / 2]) / 2;
    }
    else
    {
        median = flattenedArray[n / 2];
    }
    return median;
}

//-М- метод "выглаживания" массива для поиска медианы (вспомогательный)
int[] FlattenArray(int[,] arr)
{
    int[] result = new int[arr.Length];
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[index++] = arr[i, j];
        }
    }
    return result;
}

//рисование границ
// string header = LineCreator("Property ");
// string line1 = LineCreator("Minimum " + powOfNumber);
// string line2 = LineCreator("Maximum " + powOfNumber);
// DrawBorder(header, "\u2554", "\u2566", "\u2557");
// Console.WriteLine(header);
// DrawBorder(header, "\u2560", "\u256C", "\u2563");
// Console.WriteLine(line1);
// DrawBorder(header, "\u255A", "\u2569", "\u255D");

// string LineCreator(int n, string name)
// {
//     string line = "\u2551 " + name + " \u2551";
//     return line;
// }

//метод рисовки границ
// void DrawBorder(string sample, string InitSymb, string MidSymb, string lastSymb)
// {
//     Console.Write(InitSymb);
//     int i = 1;
//     while (i < sample.Length - 1)
//     {
//         if (sample[i] == '\u2551')
//             Console.Write(MidSymb);
//         else Console.Write("\u2550");
//         i++;
//     }
//     Console.WriteLine(lastSymb);
// }

