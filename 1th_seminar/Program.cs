//Hometask
//task #2 and task #4
// taping via keyboard commads in C# is symbolic type doesn't number. So should be convert from symbol type to number
// Created user request limits for random generator 
Console.Clear();
Console.WriteLine("Seminar1. Home task");
int LimUp;
int LimLow;
Console.Write("Set the upper limit number, LimUp - ");
LimUp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("LimUp equal: " + LimUp);
Console.Write("Set the lower limit number, LimLow - ");
LimLow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("LimLow equal: " + LimLow);
int Sum = (LimUp + LimLow);
Console.WriteLine("Sum is equal " + Sum);
int S = new Random().Next(LimLow, LimUp);
int R = new Random().Next(LimLow, LimUp);
int T = new Random().Next(LimLow, LimUp);
//Console.WriteLine("S="+S, "R="+R, "T="+T);
Console.Write("S=" + S + ", ");
Console.Write("R=" + R + ", ");
Console.WriteLine("T=" + T);
int Max;
int Min;
if (S > R)
{
    Max = S;
    Min = R;
}
else
{
    Max = R;
    Min = S;
}
if (Max < T) { Max = T; }
if (Min > T) { Min = T; }
Console.WriteLine("Max:" + Max);
Console.WriteLine("Min:" + Min);

//task #6 check even or odd number types
//string IntType = Console.WriteLine("this number is integer type: ");
//string FractType = Console.WriteLine("this number is fractional type: ");

Console.Write("check S. Result: " + S);
if (S % 2 == 0)
{ Console.WriteLine(" - this number is even "); }
else
{ Console.WriteLine(" - this number is odd"); }

Console.Write("check R. Result: " + R);
if (R % 2 == 0)
{ Console.WriteLine(" - this number is even "); }
else
{ Console.WriteLine(" - this number is odd "); }

Console.Write("check T. Result: " + T);
if (T % 2 == 0)
{ Console.WriteLine(" - this number is even "); }
else
{ Console.WriteLine(" - this number is odd "); }

//task #8 show all odd numbers from array
Console.Write("Set the limit number - ");
string? NumArrayLimit = Console.ReadLine();
int count = 1;
if (NumArrayLimit != null)
{
    int NumArrayLimitA = int.Parse(NumArrayLimit);
    string OutArray = string.Empty;
    Console.Write("show all even numbers from array: ");
    while (count < NumArrayLimitA)
    {
        if (count % 2 == 0)
        { OutArray = OutArray + count + " "; }
        count++;
    }
    if (NumArrayLimitA % 2 == 0)
        OutArray = OutArray + NumArrayLimitA;
    Console.WriteLine(OutArray);
}

//Seminar 1
/*
// Commands below:
// dotnet new console
// dotnet run
// dotnet --info
// 'variable type' 'varname'=Console.ReadLine(); --> Console.Writeline('var name');
// int 'varname' = new Random().Next(1, 10)
//int.Parse(varname) - without type
//(int)Math.Pow(number,2)
// != null - checking for not availble number (for string)

//Task1 - check what figure One is a square of figure 2
string? inputNumber1 = Console.ReadLine(); //read data from console which user write
string? inputNumber2 = Console.ReadLine();
if ((inputNumber1 != null) && (inputNumber2 != null))
{
    if ((int)Math.Pow(int.Parse(inputNumber2), 2) == int.Parse(inputNumber1))
    { Console.WriteLine("got it!"); }
    else
    { Console.WriteLine("wrong!"); }
}
//Task3 - find day of week by the number
//var 2
string? IL = Console.ReadLine();
if (IL != null)
{
    int IN = int.Parse(IL);
    string outDayofWeek = string.Empty;
    switch (IN)
    {
        case 1: outDayofWeek = "Monday"; break;
        case 2: outDayofWeek = "Tuesday"; break;
        case 3: outDayofWeek = "Wednesday"; break;
        case 4: outDayofWeek = "Thursday"; break;
        case 5: outDayofWeek = "Friday"; break;
        case 6: outDayofWeek = "Saturday"; break;
        case 7: outDayofWeek = "Sunday"; break;
        default: outDayofWeek = "this not day of week"; break;
    }
    Console.WriteLine(outDayofWeek);
    // var 3
    string outDayofWeek2 = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(IN));
    Console.WriteLine(outDayofWeek2);
}
//Task 5 - even number from -N to N range
    //Var 2
    Console.Write("your num: ");
    string? InpNum = Console.ReadLine();
    if (InpNum != null){
        int num = int.Parse(InpNum);
        for (int i = 0; i< num*2; i++){
            Console.Write(i-num);
            Console.Write(", ");
        }
        Console.Write(num);
    }
//Task 7 - 3rt number
int num = int.Parse(InpNum);
int lastDigit = num %10;
Console.WriteLine(lastDigit);
*/