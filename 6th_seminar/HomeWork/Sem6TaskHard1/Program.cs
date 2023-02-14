//На вход программы подаются три целых положительных числа. 
//Определить , является ли это сторонами треугольника. 
//Если да, то вывести всю информацию по нему - площадь, периметр, 
//значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

Console.WriteLine("Введите три стороны треугольника: ");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double alpha = 0;
double beta = 0;
double gamma = 0;
//результат 
TriangleCalculation(a, b, c);

///================================Методы========================================

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

//-М- метод расчет значений углов треугольника 
void TriangleAngles(double a, double b, double c)
{
    double alpha = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
    double beta = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
    double gamma = 180 - alpha - beta;

    Console.WriteLine("Угол альфа равен: " + alpha + " degrees");
    Console.WriteLine("Угол бетта равен: " + beta + " degrees");
    Console.WriteLine("Угол гамма равен: " + gamma + " degrees");

}

//-М- метод определения типа треугольника
void TypeOfTriangle(double alpha, double beta, double gamma)

{
    if (alpha == 90 || beta == 90 || gamma == 90)
    {
        Console.WriteLine("Треугольник прямоугольный");
    }
    else
    {
        Console.WriteLine("Треугольник не прямоугольный");
    }

    if (a == b && b == c)
    {
        Console.WriteLine("Треугольник равносторонний");
    }
    else if (a == b || a == c || b == c)
    {
        Console.WriteLine("Треугольник равнобедренный");
    }
    else
    {
        Console.WriteLine("Треугольник разносторонний");
    }
}

//-М- метод сборки методов треугольника для вывода результата
void TriangleCalculation(double a, double b, double c)
{
    if (CheckTrinagle(a, b, c) == false)
    {
        HeronEquation(a, b, c);

        TriangleAngles(a, b, c);

        TypeOfTriangle(alpha, beta, gamma);
    }
}
