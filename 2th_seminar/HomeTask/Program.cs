//Home task #2
//Task #10 Напишите код, кот. принимает на вход 3х значное число, и на выходе показывает 2ую цифру числа 
Console.Clear();
Console.WriteLine("Seminar2. Home task №2");

Console.WriteLine("Task #10");
System.Random numSintezator = new System.Random();
char[] digits = numSintezator.Next(10, 1000).ToString().ToCharArray();
Console.WriteLine(digits);
int digit1 = (int)digits[0] - 48;
int digit2 = (int)digits[1] - 48;
int digit3 = (int)digits[2] - 48;
Console.WriteLine("Rezult: " + digit2);

//Task #13 Напишите код, кот. принимает на вход 3х значное число, на выходе показывает 3ую цифру числа или сообщает, что такой цифры нет
Console.WriteLine("Task #13");
int LimUp;
int LimLow;
Console.Write("Set the upper limit number, LimUp - ");
LimUp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("LimUp equal: " + LimUp);
Console.Write("Set the lower limit number, LimLow - ");
LimLow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("LimLow equal: " + LimLow);

System.Random numSintezator2 = new System.Random();
char[] digitsOne = numSintezator2.Next(LimLow, LimUp).ToString().ToCharArray();
Console.WriteLine(digitsOne);
int CheckdigitsOne = int.Parse(digitsOne);
if (CheckdigitsOne >= 100)
{
    int digit11 = (int)digitsOne[0] - 48;
    int digit21 = (int)digitsOne[1] - 48;
    int digit31 = (int)digitsOne[2] - 48;
    Console.WriteLine("третья цифра: " + digit31);
}
else
{ Console.WriteLine("третьей цифры нет, так как число двухзначное"); }



//Task #15 Напишите код, кот. принимает на вход число дня недели и проверяет выходной ли он
// var 3
Console.WriteLine("Task #15");
Console.Write("Укажите номер дня недели: ");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inpNum = int.Parse(inputLine);
    if (inpNum == 7)
    {
        inpNum = 0;
        Console.WriteLine("Это очень забавно, но автоматическая инетпритация делает воскресенье 0ым днем. Кажется виновата христианская традиция.");
    }
    if (inpNum > 7 || inpNum < 0)
    { Console.WriteLine("Это неверное число дня недели, укажите число в дипазоне от 0 до 7!"); }
    else
    {
        string outDayofWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inpNum));
        Console.Write(outDayofWeek + " - ");
        if (outDayofWeek == "суббота" || outDayofWeek == "воскресенье")
        { Console.WriteLine("Ура! Этот день выходной!"); }
        else
        { Console.WriteLine("ох, этот день все еще не выходной!"); }
    }
}