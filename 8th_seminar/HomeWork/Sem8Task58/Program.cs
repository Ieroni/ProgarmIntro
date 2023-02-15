// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Seminar8. Home task №8");
Console.WriteLine("---Task 56---");

//Ввод
int m = ReadData("Enter the number of rows: ");
int n = ReadData("Enter the number of columns: ");
//int[,] matrix1 = new int[,] { { 2, 4 }, { 3, 2 } };
//int[,] matrix2 = new int[,] { { 3, 4 }, { 3, 3 } };

//Вывод
int[,] matrix1 = CreateTwoDimArray(m,n);
int[,] matrix2 = CreateTwoDimArray(m,n);

Console.WriteLine("Сгенерированная матрица 1: ");
PrintTwoDimArray(matrix1);
Console.WriteLine("Сгенерированная матрица 2: ");
PrintTwoDimArray(matrix2);
int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);
Console.WriteLine("Результирующая матрица: ");
PrintTwoDimArray(resultMatrix);

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
            outArray[i, j] = numberSymtezator.Next(0, 100);
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

//-М- метод произведения двух матриц
int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);
    int[,] result = new int[rows1, cols2];
   
    //* т.к не всякие две матрицы можно перемножить, то надо добавить проверку 
    if (cols1 != rows2)
    {
        throw new ArgumentException("Матрицы не согласованы"); //конструкция выражения для ошибки
    }

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
             int sum = 0;
            for (int k = 0; k < cols1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
                //Console.Write(i + " " + j + " " + k + "; "); 
            }
            result[i, j] = sum;
        }
    }

    return result;
}