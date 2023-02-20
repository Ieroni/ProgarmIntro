// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


//Ввод
int m = ReadData("введите 1ое число: ");
int n = ReadData("введите 2ое число: ");

//Вывод
int result = Ackermann(m, n);
Console.WriteLine(result);

///=============================Методы========================================
//-М- метода генерации 2умерного случайного массива
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//-М- функция Аккермана (по базовому определению)
int Ackermann(int n, int m)
{
    if (n == 0)
    { return m + 1; }
    else if (m == 0)
    { return Ackermann(n - 1, 1); }
    else
    { return Ackermann(n - 1, Ackermann(n, m - 1)); }
}