// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая бдеут построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();
Console.WriteLine("Seminar8. Home task №8");
Console.WriteLine("---Task 60---");

//Ввод
int dim1 = ReadData("введите число строк: ");
int dim2 = ReadData("введите число столбцов: ");
int dim3 = ReadData("введите число длины: ");
//Вывод
Console.WriteLine("Сгенерированная матрица: ");
int[,,] array3Dform = CreateNonRepeating3DArray(dim1, dim2, dim3);
Print3DArray(array3Dform);

///=============================Методы========================================
//-М- метода генерации 2умерного случайного массива
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//-М- генерация случайнозаданного трехмерного массива 
int[,,] CreateNonRepeating3DArray(int dim1, int dim2, int dim3)
{
int[,,] array = new int[dim1, dim2, dim3];
Random random = new Random();
HashSet<int> usedValues = new HashSet<int>(); // хеш для хранения уже использованных данных

for (int i = 0; i < dim1; i++)
{
    for (int j = 0; j < dim2; j++)
    {
        for (int k = 0; k < dim3; k++)
        {
            int value;
            do
            {
                value = random.Next(10, 99);
            } while (usedValues.Contains(value));
            array[i, j, k] = value;
            usedValues.Add(value);
        }
    }
}

    return array;
}

//-М- вывод на печать трехмерного массива
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k].ToString("00") + "(" + i + "." + j + "." + k + ") ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


