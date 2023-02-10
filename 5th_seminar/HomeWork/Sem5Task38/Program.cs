//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76
Console.Clear();
Console.WriteLine("Seminar5. Home task №5");
Console.WriteLine("---Task 36---");
// Task 36 + Отсортируйте массив методом вставки и методом подсчета, 
//а затем найдите разницу между первым и последним элементом. 
//Для задачи со звездочкой использовать заполнение массива целыми числами.

//https://www.bigocheatsheet.com/  - сложность основных алгоритмов

Console.Clear();
Console.WriteLine("Seminar5. Home task №5");
Console.WriteLine("----Task 29---");
int limUp = ReadUserRequstSingleString("Set the upper limit number, LimUp - ");
int limLow = ReadUserRequstSingleString("Set the lower limit number, LimLow - ");
int limArrUp = ReadUserRequstSingleString("установите верхний предел длинны массива, LimArrUp - ");
int limArrLow = 0;
int positiveSum = 0;
int negativeSum = 0;
int maxValue = 0;
int minValue = 0;
int diffMaxMinSimple = 0;
int diffMaxMinInsert = 0;
int diffMaxMinCount =0;
Console.WriteLine("нижний предел длинны массива, LimArrLow = 0");
//результат заполнения массива
int arrLen = UserDitgitCheck(limArrLow, limArrUp, "введите длину массива: ");
int[] arr = Gen1DArr(arrLen, limLow, limUp);
Console.WriteLine("Сгенерированный массив");
Print1DArray(arr);
NegPosSum(arr);
MaxMinValue(arr);

//Вывод результата
PrintTwoLineString("Cумма позитивных: ", positiveSum);
PrintTwoLineString("Cумма негативных: ", negativeSum);
PrintTwoLineString("Max is: ", maxValue);
PrintTwoLineString("Min is: ", minValue);
PrintTwoLineString("diff by Abs is: ", diffMaxMinSimple);
Console.WriteLine("");
Console.WriteLine("--Метод встави отсортировал массив--");
Print1DArray(MethodSortArratByPaste(arr));
PrintTwoLineString("Подсчет разницы между 1ым и последним: ", diffMaxMinInsert);
Console.WriteLine("");
Console.WriteLine("--Метод подсчета отсортировал массив--");
Print1DArray(SimpleCountingSort(arr));
PrintTwoLineString("Подсчет разницы между 1ым и последним: ", diffMaxMinCount);

///=============================Методы========================================

////Методы ввода/вывода--------------------------------------------------
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
int[] Gen1DArr(int num, int limLowArr, int limUpArr)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(limLowArr, limUpArr);
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

//-М- метод вывода результата в виде двух строк (для типа int)
void PrintTwoLineString(string msg1, int msg2)
{
    Console.Write(msg1);
    Console.WriteLine(msg2);
}

////Методы основных расчетов-------------------------------------------
//-М- метод поиска сумм отрицательных и позитивных значений массива
void NegPosSum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        { positiveSum += arr[i]; }
        else
        { negativeSum += arr[i]; }
    }
}

//-М- метод поиска максимальных и минимальных чисел в массиве и их суммы
void MaxMinValue(int[] arr)
{
    maxValue = arr[0];
    minValue = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxValue)
        { maxValue = arr[i]; }
        if (arr[i] < minValue)
        { minValue = arr[i]; }
    }
    diffMaxMinSimple = Math.Abs((maxValue) - (minValue));
}

//-м- метод сортировки вставкой 
int[] MethodSortArratByPaste(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int k = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > k)
        {
            arr[j + 1] = arr[j];
            arr[j] = k;
            j--;
        }
    }
    diffMaxMinInsert = Math.Abs(arr[0] - arr[arr.Length - 1]);
    return arr;
}

//-м- метод сортировки подсчетом (вар для отрицательных чисел)
int[] SimpleCountingSort(int[] arr)
{
   {
        int max = arr.Max();  //max min найдем заново, для независимости метода
        int min = arr.Min();
        int range = max - min + 1;
        int[] count = new int[range]; //для численного диапазона
        int[] output = new int[arr.Length]; //для порядкового диапазона
        for (int i = 0; i < arr.Length; i++) 
        {
            count[arr[i] - min]++;
        }
        for (int i = 1; i < count.Length; i++) 
        {
            count[i] += count[i - 1];
        }
        for (int i = arr.Length - 1; i >= 0; i--) 
        {
            output[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }
        for (int i = 0; i < arr.Length; i++) 
        {
            arr[i] = output[i];
        }
    }
    diffMaxMinCount = Math.Abs(arr[0] - arr[arr.Length - 1]);
    return arr;
}