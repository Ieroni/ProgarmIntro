using System;
using System.Text.RegularExpressions;
///Task additional - выбрать случайное имя из заданого списка
Console.Clear();
Console.WriteLine("Seminar4. Home task №4");
Console.WriteLine("---Task Additional---");

//Ввод данных
string coordinates = ReadStringData("введите имена - ");
// разделения строки для поиска цифровых значений
string mystr = Regex.Replace(coordinates, @"\d", ""); // убираем возможные цифры в строке
Console.WriteLine(mystr);
char[] separators = new char[] { ' ', '.', ',' };
string[] subs = mystr.Split(separators, StringSplitOptions.RemoveEmptyEntries);

// Вывод результата
Console.WriteLine("Бот, а какое имя самое красивое по твоему мнению?");
Console.WriteLine("самое красивое это __{0}__!", subs[RundGenByLimit(subs)]);
Console.WriteLine("");
Console.WriteLine("а вот и другие имена из списка");

///Методы
//-м- необязательная конструкция вывод всех подстрок в имени
foreach (var sub in subs)
{
    Console.WriteLine($"Имя: {sub}");
}

// -M- метод случайного выбора по индексу
int RundGenByLimit(string[] name)
{
System.Random numSintezator = new System.Random();
int mIndex = numSintezator.Next(name.Length); // генерация случайного индекса
return mIndex;
}

//-М- Чтение ввода строки 
string ReadStringData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "0";
    return inputLine;
}
