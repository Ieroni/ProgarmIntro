//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Clear();
Console.WriteLine("Seminar5. Home task №5");
Console.WriteLine("---Task 34---");
//Task34 + Отсортировать массив методом пузырька
int LimUp = ReadUserRequstSingleString("Верхний предел массива, (для 3хзначных поз LimUp=999) - ");
int LimLow = ReadUserRequstSingleString("Верхний предел массива, (для 3хзначных поз LimLow=100)  - ");
int LimArrUp = ReadUserRequstSingleString("установите верхний предел возможной длины массива, LimArrUp - ");
int LimArrLow = 0;
Console.WriteLine("нижний предел возможной длины массива, LimArrLow = 0");

//результат заполнения массива
int arrLen = UserDitgitCheck(LimArrLow, LimArrUp, "введите длину массива: ");
int[] arr = Gen1DArr(arrLen, LimLow, LimUp);
Print1DArray(arr);

//Вывод результата
PrintDataMsgAndRes("кол-во четных чисел в массиве: ", CountEvenElem(arr));
Console.WriteLine("--Task34*-Сортировка пузьрком--");
Print1DArray(BubbleSort(arr));

///=============================Методы========================================
////Методы ввода/вывода------------------------------------------
//-м- метода ввода единичного входного аргумента типа "строка". 
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

//-М- Метод генерации массива в заданных пределах
int[] Gen1DArr(int num, int LimLowArr, int LimUpArr)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(LimLowArr, LimUpArr);
    }
    return arr;
}

//-М- Метод вывода массива
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");

    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//-M- Вывод данных пользователя
void PrintDataMsgAndRes(string msg, double res)
{
    Console.WriteLine(msg + res);
}


////Методы основных расчетов------------------------------------
//-М- метод поиска четных элементов элемента массива
int CountEvenElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Reason(arr[i]))
        {
            res++;
        }
    }
    return res;
}
bool Reason(int n)
{ return (n % 2 == 0); }

//-M- метод сортировки пузырьком
int[] BubbleSort(int[] arr)
{
    int output;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                output = arr[i];
                arr[i] = arr[j];
                arr[j] = output;
            }
        }
    }
    return arr;
}
