//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//*Найдите площадь треугольника образованного пересечением 3 прямых

// Console.Clear();
// Console.WriteLine("Seminar6");
// Console.WriteLine("----Task 43---");

//ввод
double triangleSideA = 0;
double triangleSideB = 0;
double triangleSideC = 0;
double b1 = ReadUserRequstSingleString("введите b1: ");
double k1 = ReadUserRequstSingleString("введите k1: ");
double b2 = ReadUserRequstSingleString("введите b2: ");
double k2 = ReadUserRequstSingleString("введите k2: ");
double b3 = ReadUserRequstSingleString("введите b3: ");
double k3 = ReadUserRequstSingleString("введите k3: ");

//Вывод
TriangleSideLenghtCalc();
Console.WriteLine("cторона А равна: " + triangleSideA);
Console.WriteLine("cторона B равна: " + triangleSideB);
Console.WriteLine("cторона C равна: " + triangleSideC);
TriangleCalculation(triangleSideA, triangleSideB, triangleSideC);

///=============================Методы========================================
////-М- метода ввода единичного входного аргумента типа "строка". 
double ReadUserRequstSingleString(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

//-М- метод поиска точек перечения 2ух произвольных прямых, заданных уравнениями
double[] IntersectionEquation(double varB1, double varB2, double varK1, double varK2)
{
    double coordX = 0;
    double coordY = 0;
    coordX = (varB2 - varB1) / (varK1 - varK2);
    coordY = varK1 * coordX + varB1;
    //Console.WriteLine("(" + coordX + ", " + coordY + ")");
    double[] arr = new double[2];
    arr[0] = coordX;
    arr[1] = coordY;
    return arr;
}

//-М- метод поиска длин сторон по найденым пересечениям
void TriangleSideLenghtCalc()
{
    double[] pointXYline1line2 = IntersectionEquation(b1, b2, k1, k2);
    double[] pointXYline1line3 = IntersectionEquation(b1, b3, k1, k3);
    double[] pointXYline2line3 = IntersectionEquation(b2, b3, k2, k3);

    double coordX1 = pointXYline1line2[0];
    double coordY1 = pointXYline1line2[1];
    double coordX2 = pointXYline1line3[0];
    double coordY2 = pointXYline1line3[1];
    double coordX3 = pointXYline2line3[0];
    double coordY3 = pointXYline2line3[1];
    Console.WriteLine("координаты точки пересечения линий 1 и 2: " + "(" + coordX1 + ", " + coordY1 + ")");
    Console.WriteLine("координаты точки пересечения линии 1 и 3: " + "(" + coordX2 + ", " + coordY2 + ")");
    Console.WriteLine("координаты точки пересечения линии 2 и 3: " + "(" + coordX3 + ", " + coordY3 + ")");

    triangleSideA = LineLenghtCalcByCoord(coordX1, coordX2, coordY1, coordY2);
    triangleSideB = LineLenghtCalcByCoord(coordX1, coordX3, coordY1, coordY3);
    triangleSideC = LineLenghtCalcByCoord(coordX2, coordX3, coordY2, coordY3);
}

//-М- метод расчета длины по двум координатам
double LineLenghtCalcByCoord(double X1, double X2, double Y1, double Y2)
{
    double sideLenght = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
    Console.WriteLine(sideLenght);
    return sideLenght;
}

///Методы вычисленеий для треугольника 

//-М- метод проверки сторон треугольника
bool CheckTrinagle(double a, double b, double c)
{
    bool enableCalFLag = false;
    if (a <= 0 || b <= 0 || c <= 0)
    {
        Console.WriteLine("Неверный ввод: стороны должны быть целыми положительными числами.");
        enableCalFLag = true;
    }

    if (a + b <= c || a + c <= b || b + c <= a)
    {
        Console.WriteLine("Эти стороны не образуют треугольник");
        enableCalFLag = true;
    }
    return enableCalFLag;
}

//-М- метод расчет площади и периметра треугольника по формуле Герона 
void HeronEquation(double a, double b, double c)
{
    double perimeter = a + b + c;
    double semiperimeter = perimeter / 2;
    double area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));

    Console.WriteLine("Периметр треугольника равен: " + perimeter);
    Console.WriteLine("Площадь треугольника равна: " + area);

}

//-М- метод сборки методов треугольника для вывода результата
void TriangleCalculation(double a, double b, double c)
{
    if (CheckTrinagle(a, b, c) == false)
    {
        HeronEquation(a, b, c);
    }
}
