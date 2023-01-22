// dotnet new console
// dotnet run
// 'variable type' 'varname'=Console.ReadLine(); --> Console.Writeline('var name');
// int 'varname' = new Random().Next(1, 10)
//int.Parse(varname) - without type
//(int)Math.Pow(number,2)
// null - checking for not availble number

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
//Console.Read();
int Sum = (LimUp + LimLow);
Console.WriteLine("Sum is equal " + Sum);
int S = new Random().Next(LimLow, LimUp);
int R = new Random().Next(LimLow, LimUp);
int T = new Random().Next(LimLow, LimUp);
//Console.WriteLine("S="+S, "R="+R, "T="+T);
Console.WriteLine("S=" + S);
Console.WriteLine("R=" + R);
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

//task #6 check integer or fractional number types
//string IntType = Console.WriteLine("this number is integer type: ");
//string FractType = Console.WriteLine("this number is fractional type: ");

Console.Write("check S. Result: " + S);
if (S % 2 == 0)
{ Console.WriteLine(" - this number is even: "); }
else
{ Console.WriteLine(" - this number is odd"); }

Console.Write("check R. Result: " + R);
if (R % 2 == 0)
{ Console.WriteLine(" - this number is even: "); }
else
{ Console.WriteLine(" - this number is odd: "); }

Console.Write("check T. Result: " + T);
if (T % 2 == 0)
{ Console.WriteLine(" - this number is even: "); }
else
{ Console.WriteLine(" - this number is odd: "); }

//task #8 show all odd numbers from array
Console.WriteLine("show all odd numbers from array: ");
int count = 1;
while (count < LimUp)
{
    if (count % 2 == 0)
    { Console.Write(" " + count); }
    count++;
}