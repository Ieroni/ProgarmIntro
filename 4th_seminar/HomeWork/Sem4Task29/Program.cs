//Task 29 Напишите программу, которая задает массив из 8и элементов и выводит их на экран
///Task 29*Ввести с клавиатуры длинну массива и дипазон значений элементов
using System.Numerics;
Console.Clear();
Console.WriteLine("Seminar4. Home task №4");
Console.WriteLine("----Task 29---");
int LimUp = ReadUserRequstSingleString("Set the upper limit number, LimUp - ");
int LimLow = ReadUserRequstSingleString("Set the lower limit number, LimLow - ");
int arrLen = UserDitgitCheck(LimLow, LimUp, "введите длину массива: ");

///методы
//-м- метода ввода единичного входного аргумента типа "строка". Парсинг в Biginteger
int ReadUserRequstSingleString(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//-м- метод возобновляемой проверики ввденого числа по заданным пределам. 
int UserDitgitCheck(int limitLow, int limitUp, string text)
{
    int variable = ReadUserRequstSingleString(text);
    while (variable < limitLow || variable > limitUp)
    {
        if (variable < limitLow)
        {
            Console.WriteLine("введенное число " + variable + " меньше чем " + limitLow);
            variable = ReadUserRequstSingleString("введите число заново: ");
        }
        else if (variable > limitUp)
        {
            Console.WriteLine("введенное число " + variable + " больше чем " + limitUp);
            variable = ReadUserRequstSingleString("введите число заново: ");
        }
    }
    return variable;
}

//Метод читает запрос пользователя в виде единичной строки
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] Gen1DArr(int num, int LimUp, int LimLow)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(LimLow, LimUp);
    }
    return arr;
}

void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

//int arrLen = ReadData("введите длину массива");
int[] arr = Gen1DArr(arrLen, LimUp, LimLow);
Print1DArray(arr);