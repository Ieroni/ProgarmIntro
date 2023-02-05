// //HOmeTask #3
//----------------------------------------------
using System;
using System.Text.RegularExpressions;
Console.Clear();
Console.WriteLine("Seminar3. Home task №3");
//-----------------------------------------------------------------------------------
//Task #19 - принимает на вход 5ти значное число, и проверяет палиндр ли оно
/// Variant 1
Console.WriteLine("---------Task #19---------");
//зададим пределы случайного числа
int LimUp = ReadLimitData("Set the upper limit number, LimUp - ");
int LimLow = ReadLimitData("Set the lower limit number, LimLow - ");

DateTime d1 = DateTime.Now;                   // замер времени
FindPaliandr(RundGenByLimits(LimUp, LimLow)); //вызовем метод поиска палиандра 

//-M- метод преобразования строки в число, для задания входных параметров пользователем
int ReadLimitData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

//-M- Метод задания случайного числа из заданного на входе диапазона
char[] RundGenByLimits(int Upper, int Lower)
{
    System.Random numSintezator = new System.Random();
    char[] digitsOne = numSintezator.Next(Lower, Upper).ToString().ToCharArray();
    Console.Write(digitsOne);
    return digitsOne;
    //проверка длины числа и проверка его на признак палиандра
}

//-M- метод для поиска палиндрома
void FindPaliandr(char[] InpPaliandr)
{
    if (InpPaliandr.Length == 5)
    {
        int digit11 = (int)InpPaliandr[0] - 48;
        int digit21 = (int)InpPaliandr[1] - 48;
        int digit31 = (int)InpPaliandr[2] - 48;
        int digit41 = (int)InpPaliandr[3] - 48;
        int digit51 = (int)InpPaliandr[4] - 48;
        if (digit11 == digit51 && digit21 == digit41)
        { Console.WriteLine(" - Это Палиндром!"); }
        else
        { Console.WriteLine(" - Это не Палиандр!"); }
    }
    else
    { Console.WriteLine(" - это число не 5ти-значное! введите пределы заново"); }
}
Console.WriteLine(DateTime.Now - d1);         // стоп временя
//------------------------------------

///Task #19 Variant 2 - сделать через словарь 4ех значных полндромов
Console.WriteLine("---------Task #19 Var2-------");

DateTime d2 = DateTime.Now;                   // замер времени
Dictionary<int, int> PalindromFIll()
{
    Dictionary<int, int> palindrom = new Dictionary<int, int>();
    //Вложенный цикл для заполнения словаря
    for (int i = 1; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            int key = j * 10 + i;
            int value = i * 1000 + j * 100 + j * 10 + i;
            palindrom.Add(key, value);
        }
    }
    return palindrom;

}
//-M- Метод проверяющий на полиндром
bool CheckPalindrom(int inputNumber, Dictionary<int, int> palindrom)
{
    // Делаем четырехзначное число без 3й цифры
    int fourDigitNumber = (inputNumber / 1000) * 100 + inputNumber % 100;
    // Проверка на наличие в словаре палиндрома
    return palindrom.ContainsValue(fourDigitNumber);
}
int inputNumber = 0;
string inputLine = ReadStringData("введите 5-значное число: ");
if (int.TryParse(inputLine, out inputNumber))
{
    if (inputNumber > 9999 && inputNumber < 100000)
    {
        Dictionary<int, int> fourDigitPalindrom = PalindromFIll();
        PrintResult(CheckPalindrom(inputNumber, fourDigitPalindrom) ? "Это палиндром" : "Это не палиндром");
    }
    else
    {
        PrintResult("Это не пятнизначное число");
    }
}
else
{
    PrintResult("Это не число");
}

Console.WriteLine(DateTime.Now - d2);         // стоп временя

///Используемые методы прописаны ниже 
string ReadStringData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "0";
    return inputLine;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

//----------------------------------------------------------------------------------------------------
//Task #21 - принимает на вход координаты 2ух точек, и находит расстояние в пространстве 3ех измерений
Console.WriteLine("-------------Task #21----------");
//Вывод результата
PrintData("радиус вектор точек ", CalcLim(  // вводим координаты точек
    ReadData("point of coord x1 "),
    ReadData("point of coord x2 "),
    ReadData("point of coord y1 "),
    ReadData("point of coord y2 "),
    ReadData("point of coord z1 "),
    ReadData("point of coord z2 ")));

//-M- Ввод данных пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//-M- Вывод данных пользователя
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

//-M- Вычисляем расстояние между 2я точками
double CalcLim(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return res;
}

///Task #21* - Сделать метод загрузки точек A(3,6,5), B(5,4,5) и т.д.
Console.WriteLine("--Task #21*--Сделать метод загрузки координат точек");
string coordinates = ReadStringData("введите координаты в любом формате, например A(3,4,6)  B(4,5,4): ");

// -M- метод разделения строки для поиска цифровых значений
string mystr = Regex.Replace(coordinates, @"\d", "");
string mynumber = Regex.Replace(coordinates, @"\D", "");
//Console.WriteLine(mystr);
//Console.WriteLine(mynumber);
var X1 = mynumber[0];
var Y1 = mynumber[1];
var Z1 = mynumber[2];
var X2 = mynumber[3];
var Y2 = mynumber[4];
var Z2 = mynumber[5];

PrintData("радиус вектор точек ", CalcLim(X1,X2,Y1,Y2,Z1,Z2));

//----------------------------------------------------------------------------------------
//Task #23 - принимает на вход число N и выдает таблицу кубов от 1 до N. + *создать границы 
Console.WriteLine("-----------Task #23------------");
//-M- Сборка таблицы кубов
int SetNumberArray = UserDitgitCheck(0, 100, "введите число: ");
int powOfNumber = UserDitgitCheck(0, 9, "введите желаемую степень: ");
string header = LineCreator(SetNumberArray, 1, "Массив             ");
string line1 = LineCreator(SetNumberArray, powOfNumber, "Cтепень массива = " + powOfNumber);

DrawBorder(header, "\u2554", "\u2566", "\u2557");
Console.WriteLine(header);
DrawBorder(header, "\u2560", "\u256C", "\u2563");
Console.WriteLine(line1);
DrawBorder(header, "\u255A", "\u2569", "\u255D");

///Используемые методы прописаны ниже 

//-M- метод проверки введеного числа по ограниченям ввода
int UserDitgitCheck(int limitLow, int limitUp, string text)
{
    int variable = ReadData(text);
    while (variable < limitLow || variable > limitUp)
    {
        if (variable < limitLow)
        {
            Console.WriteLine("введенное число " + variable + " меньше чем " + limitLow);
            variable = ReadData("введите число заново: ");
        }
        else if (variable > limitUp)
        {
            Console.WriteLine("введенное число " + variable + " больше чем " + limitUp);
            variable = ReadData("введите число заново: ");
        }
    }
    return variable;
}

//-M- метод создания строки 
string LineCreator(int n, int p, string name)
{
    string line = "\u2551 " + name + " \u2551";
    int AddLine = 0;
    int VirtLine = 0;
    int GapSize = 0;
    for (int i = 1; i <= n; i++)
    {
        AddLine = (int)Math.Pow(i, p);
        VirtLine = (int)Math.Pow(i, powOfNumber);
        GapSize = CountDigitsByDiv(VirtLine) - CountDigitsByDiv(AddLine);
        line += AddLine.ToString().PadRight(CountDigitsByDiv(AddLine) + GapSize) + "\u2551";
    }
    return line;
}
//-M- метод расчета строки по входному массиву
// int ArrayToCube(cube)
// { cube = (int)Math.Pow(i, p); }

// метод вычисления длины числа
int CountDigitsByDiv(int n)
{
    int count = (n == 0) ? 1 : 0;
    while (n != 0)
    {
        n /= 10;
        count++;
    }

    return count;
}

//метод рисовки границ
void DrawBorder(string sample, string InitSymb, string MidSymb, string lastSymb)
{
    Console.Write(InitSymb);
    int i = 1;
    while (i < sample.Length - 1)
    {
        if (sample[i] == '\u2551')
            Console.Write(MidSymb);
        else Console.Write("\u2550");
        i++;
    }
    Console.WriteLine(lastSymb);
}





