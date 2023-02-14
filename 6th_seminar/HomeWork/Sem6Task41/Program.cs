//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь. -- 0, 7, 8, -2, -2 -> 2   1, -7, 567, 89, 223-> 3
//* Пользователь вводит число нажатий, затем программа следит за нажатиями с клавиатуры 
//и выдает сколько чисел больше 0 было введено.
using System;
using System.Text;
using System.Text.RegularExpressions;
Console.Clear();
Console.WriteLine("Seminar5. Home task №5");
Console.WriteLine("---Task 41---");
Console.WriteLine("решение объединяет две задачи в одну");

//Ввод
int maxClicks = ReadUserRequstSingleString("укажите число нажатий: ");
//Вывод
string stringForValyeZeroCheck = RegetStringToNumberOnly(UserButtonsClickMonitor(maxClicks));
FindZeroInUserDefineString(stringForValyeZeroCheck);

//-М- метода ввода единичного входного аргумента типа "строка". 
int ReadUserRequstSingleString(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//-М- метод отслеживания нажатий пользователем (do - while констрцкция)
string UserButtonsClickMonitor(int maximumClick)
{
    StringBuilder inputString = new StringBuilder(); //для модификации строки
    char input;
    do
    {
        input = Console.ReadKey().KeyChar;
        if (input != '\r')
        {
            inputString.Append(input);
        }
    } while (inputString.Length < maximumClick);//input != '\r' );

    string UserElementsString = inputString.ToString();
    return UserElementsString;
}

string RegetStringToNumberOnly(string inpString)
{
    string patternAllNumber = @"-?\\d+";  // паттерн для прореживания строки по негативным числам
    string patternRemoveLatter = @"[a-zA-Z]";
    string stringLetterReget = Regex.Replace(inpString, patternRemoveLatter, " ");
    string stringReget = Regex.Replace(stringLetterReget, patternAllNumber, " "); //@"[^\d]"  @"(?<=\s)-\d+(?=\s)"
    Console.WriteLine();
    //Console.WriteLine(stringReget);
    return stringReget;
}

//-М- метод проверк введеной строки на 0. Содержит прореживнаие строки по списку символов
void FindZeroInUserDefineString(string clearString)
{
    char[] separators = new char[] { ' ', '.', ',' };
    string[] subs = clearString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    int count = 0;
    int numberFromString = 0;
    for (int i = 0; i < subs.Length; i++)
    {
        numberFromString = int.Parse(subs[i]);
        if (numberFromString > 0) { count++; }
    }
    Console.WriteLine($"Количесвто введеных чисел больше 0 равно {count}");
}
