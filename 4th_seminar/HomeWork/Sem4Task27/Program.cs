//Task 27 Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
///Task 27* сделать оценку времени алгоритма через вещественные числа и строки
using System;
using System.Text.RegularExpressions;
Console.Clear();
Console.WriteLine("Seminar4. Home task №4");
Console.WriteLine("Task 27. Дано число. Найдите сумму его цифр");

int numberA = ReadUserRequstSingleString("Введите число : ");
float numberB = (float)numberA;

//Время вычислений------------------------------------------
DateTime DigitsMethodTime = DateTime.Now;
float res1 = CountDigitsByDiv(numberB);
PrintTwoLineString("Сумма чисел CountDigitsByDiv:", res1);
Console.WriteLine(DateTime.Now - DigitsMethodTime);

DateTime StringMethodTime = DateTime.Now;
int res2 = SumDigitStr1(numberA);
PrintTwoLineString("Сумма чисел SumDigitStr1:", res2);
Console.WriteLine(DateTime.Now - StringMethodTime);

DateTime StringMethodTime2 = DateTime.Now;
int res3 = SumDigitStr2(numberA);
PrintTwoLineString("Сумма чисел SumDigitStr2, Лямбда:", res3);
Console.WriteLine(DateTime.Now - StringMethodTime2);
//Время вычислений------------------------------------------

///Методы
//-M- Строковый метод расчета числа
int SumDigitStr1(int num)
{
    Console.WriteLine("Метод строк 1. Более быстрый");
    // метод намного более быстрый!
    int result = 0;
            char[] array = num.ToString ( ).ToCharArray ( );
            for ( int i=0; i < array.Length; i++ )
            {
                result += array [ i ] - '0';
            }
    return result;
}
int SumDigitStr2(int num)
{
    Console.WriteLine("Метод строк 2, - лямбда выражение");
    //здесь указан интересный метод через лямда выражение (ситнаксис делегатов?)
    int result = num.ToString().Sum(c => c - '0'); //лямбда выражение 
    return result;
}

//-M- вещественный метод расчета числа
float CountDigitsByDiv(float number)
{
    int newNumber = (int)Math.Abs(number); //т.к числа могут ввести и отрицательные
    int summ = 0;
    while (newNumber != 0)
    {
        summ += newNumber % 10;    
        newNumber /= 10;  
    }
    return summ;
}

//Метод вывода результата в виде двух строк (для типа int and float)
void PrintTwoLineString(string msg1, float msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

//Метод читает запрос пользователя в виде единичной строки
int ReadUserRequstSingleString(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}



