// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//int m = 1;
//int n = 15;
//Ввод
int m = ReadData("введите 1ое число: ");
int n = ReadData("введите 2ое число: ");

//Вывод
int sum = (m < n)? (SumOfIntegers(m, n)):(SumOfIntegers(n, m));
Console.WriteLine("Сумма позитивных чисел между " + m + " и " + n + " равна " + sum);


///=============================Методы========================================
//-М- метода генерации 2умерного случайного массива
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//-М- метода рекррентного подсчета суммы элементов (края включены в расчет) 
int SumOfIntegers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else if (m <= 0)
    {
        return SumOfIntegers(1, n);
    }
    else
    { return m + SumOfIntegers(m + 1, n); }
}
