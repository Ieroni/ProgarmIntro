//HOmeTask #3
Console.Clear();
Console.WriteLine("Seminar3. Home task №3");

//Task #19 - принимает на вход 5ти значное число, и проверяет палиндр ли оно
  // Variant 1
Console.WriteLine("Task #19");
int LimUp = ReadLimitData("Set the upper limit number, LimUp - ");
int LimLow = ReadLimitData("Set the lower limit number, LimLow - ");
RundGenByLimits(LimUp, LimLow);

//метод преобразования строки в число, для задания входных параметров пользователем
int ReadLimitData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод задания случайного числа из заданного на входе диапазона
void RundGenByLimits(int Upper, int Lower)
{
    System.Random numSintezator = new System.Random();
    char[] digitsOne = numSintezator.Next(Lower, Upper).ToString().ToCharArray();
    Console.Write(digitsOne);
    //проверка длины числа и проверка его на признак палиандра
if (digitsOne.Length == 5)
{
    int digit11 = (int)digitsOne[0] - 48;
    int digit21 = (int)digitsOne[1] - 48;
    int digit31 = (int)digitsOne[2] - 48;
    int digit41 = (int)digitsOne[3] - 48;
    int digit51 = (int)digitsOne[4] - 48;
    if (digit11==digit51 && digit21==digit41)
        {Console.WriteLine(" - Это Палиандр!"); }
    else
         {Console.WriteLine(" - Это не Палиандр!"); }
}
else
{ Console.WriteLine(" - это число не 5ти-значное! введите пределы заново"); }
}

  // Variant 2 - сделать через словарь 4ех значных полндромов

//Task #21 - принимает на вход координаты 2ух точек, и находит расстояние в пространстве 3ех измерений
Console.WriteLine("Task #21");
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Вывод данных пользователя
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

//Вычисляем расстояние между 3я точками
double CalcLim(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res =0;
    res = Math.Sqrt(Math.Pow(x1 -x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1-z2, 2));
    return res;
}

//Вывод результата
PrintData("радиус вектор точек ", CalcLim (  // вводим координаты точек
    ReadData("point of coord x1 "),
    ReadData("point of coord x2 "),
    ReadData("point of coord y1 "),
    ReadData("point of coord y2 "),
    ReadData("point of coord z1 "),
    ReadData("point of coord z2 ")));

  //Сделать метод загрузки точек A(3,6,5), B(5,4,5) и т.д.

//Task #23 - принимает на вход число N и выдает таблицу кубов от 1 до N. + создать границы 
Console.WriteLine("Task #23");
void PrintData2(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}
string LineCreator(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    { s += Math.Pow(i, p).ToString() + "\t" ; }
    return s;
}
//ввод данных
int num = ReadData("введите N: ");
//Сборка таблицы кубов
string header = LineCreator(num, 1);
string line1 = LineCreator(num, 3); 
PrintData2(header, line1);