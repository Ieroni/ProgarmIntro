//HomeTask #4
Console.Clear();
Console.WriteLine("Seminar4. Home task №4");
Console.WriteLine("---Task 25---");
//Task #25 Напишите цикл, который принимает на вход 2а числа (А и В) и возводит А в натуральную степень В
//зададим пределы случайного числа
float LimUp = ReadUserRequstSingleString("Set the upper limit number, LimUp - ");
float LimLow = ReadUserRequstSingleString("Set the lower limit number, LimLow - ");
//Ввод желаемых чисел
string variable = ReadUserRequstSingleStringAsStr("Программа расчета степени. Для продолжения введите 'cтарт' ");
while (variable == "старт" || variable == "y")
{
    if (variable == "старт" || variable == "y")
    {
        float SetNumberArray = UserDitgitCheck(LimLow, LimUp, "введите число для расчета: ");
        float powOfNumber = UserDitgitCheck(LimLow, LimUp, "введите желаемую степень B: ");
        float Result = CalcLim(SetNumberArray, powOfNumber);
        Console.WriteLine(Result);
    }
    else
    { Console.WriteLine("закрываем программу"); }
    variable = ReadUserRequstSingleStringAsStr("продолжить расчет, y/n? ");
}
Console.WriteLine("закрываем программу");

//Task 25* написать калькулятор с операциями +, -, /, *, pow
Console.WriteLine("--Программа калькулятор--");
Console.WriteLine("подсказка операторов: +| , -| , *| , /| , ^|. 'fc' - для сброса.");
string skolkolator = ReadUserRequstSingleStringAsStr(" Для начала работы введите 'on' ");

//начало работы с программой
while (skolkolator == "on" ||  skolkolator =="fc")
{
    if (skolkolator == "on" ||  skolkolator =="fc")
    {
        float TT = SimpleCalculator(ReadUserRequstSingleString("первое значение: "),
        ReadUserRequstSingleStringAsStr("Выберете операцию: "),
                                  ReadUserRequstSingleString("второе значение: "));
        Console.Write("Ответ: ");
        Console.WriteLine(TT);
    }
    else
    { Console.WriteLine("закрываем программу"); }
    skolkolator = ReadUserRequstSingleStringAsStr("");
}
Console.WriteLine("закрываем программу");

///методы
//-М- метода ввода единичного входного аргумента типа "строка". 
float ReadUserRequstSingleString(string msg)
{
    Console.Write(msg);
    return float.Parse(Console.ReadLine() ?? "0");
}

//-М- метод простого калькулятора
float SimpleCalculator(float firstVal, string Mode, float sectVal)
{
    string? calculatorMode = Mode;
    float OperationResult = 0;
    switch (calculatorMode)
    {
        case "+": OperationResult = firstVal + sectVal; break;
        case "-": OperationResult = firstVal - sectVal; break;
        case "*": OperationResult = firstVal * sectVal; break;
        case "/":
            if (firstVal == 0) { OperationResult = 0; }
            else if (sectVal == 0) { Console.WriteLine("деление на 0 невозможно!"); }
            else { OperationResult = firstVal / sectVal; }
            break;
        case "^": OperationResult = CalcLim(firstVal, sectVal); break;
        default:
            Console.WriteLine("неизвестная команда, повторите ввод!"); break;
    }
    return OperationResult;
}

//-M- метод задания пользователем строковых переменных
string ReadUserRequstSingleStringAsStr(string msg)
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}

//-м- метод возобновляемой проверики ввденого числа по заданным пределам. 
float UserDitgitCheck(float limitLow, float limitUp, string text)
{
    float variable = ReadUserRequstSingleString(text);
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

//-м- метод расчет возведения в степен по 2ум входным аргументам
float CalcLim(float inpValue, float PowNumber)
{
    float res = 0;
    res = (float)Math.Pow(inpValue, PowNumber);
    return res;
}
