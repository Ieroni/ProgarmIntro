//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Seminar5. Home task №5");
Console.WriteLine("---Task 36---");
// Task 36 + Найдите все пары в массиве и выведите пользователю
Console.Clear();
Console.WriteLine("Seminar5. Home task №5");
Console.WriteLine("----Task 29---");
int limUp = ReadUserRequstSingleString("Set the upper limit number, LimUp - ");
int limLow = ReadUserRequstSingleString("Set the lower limit number, LimLow - ");
int limArrUp = ReadUserRequstSingleString("установите верхний предел длинны массива, LimArrUp - ");
int limArrLow = 0;
Console.WriteLine("нижний предел длинны массива, LimArrLow = 0");

//результат заполнения массива
int arrLen = UserDitgitCheck(limArrLow, limArrUp, "введите длину массива: ");
int[] arr = Gen1DArr(arrLen, limLow, limUp);
Print1DArray(arr);
PrintTwoLineString("сумма нечетных элементов: ", CountEvenElem(arr));
Console.WriteLine("");
Console.WriteLine("--Task36*-найти все пары в массиве--");
FindPairsInArray(arr);
FindPairsOfElem(arr);

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

////Методы основных расчетов------------------------------------
//-М- метод подсчета элементов на четных позициях

int CountEvenElem(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        res += arr[i];
    }
    return res;
}

//-М- метод поиска пар в массиве
void FindPairsInArray(int[] arr)
{
    int n = arr.Length;
    Dictionary<int, List<int>> usedPairs = new Dictionary<int, List<int>>(); //usedPairs используется для хранения уже найденных пар. 

    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (arr[i] == arr[j])
            {
                if (!usedPairs.ContainsKey(arr[i])) //проверка наличия чисел пары в словаре 
                {
                    usedPairs[arr[i]] = new List<int>(); //Ключ в словаре — это число в паре, а значение — это список позиций во входном массиве, где появляется это число.
                }
                if (!usedPairs[arr[i]].Contains(i) && !usedPairs[arr[i]].Contains(j)) //проверка наличия индексов в паре
                {
                    Console.WriteLine("Пары чисел " + arr[i] + " и " + arr[j] + " расположены на позициях " + i + " и " + j);
                    usedPairs[arr[i]].Add(i);
                    usedPairs[arr[i]].Add(j);
                }
            }
        }
    }
    if (usedPairs.Count == 0)
    { Console.WriteLine("Пар не встречается."); }
}

//-М- метод счета коли-ства повторяющихся элементов
void FindPairsOfElem(int[] arr)
{
    var dict = new Dictionary<int, int>();
    foreach (var value in arr)
    {
        dict.TryGetValue(value, out int count); // ищем значения
        dict[value] = count + 1;
    }
    foreach (var pair in dict)
        if (pair.Value > 1)
        { Console.WriteLine("Значение {0} встречается {1} раз.", pair.Key, pair.Value); }
        else
        {
            Console.WriteLine("Дубликатов не встречается.");
            break;
        }
}





