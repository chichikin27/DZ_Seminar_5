
/*
//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Write("Введите вход первого отрезка: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите выход первого отрезка: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите вход второго отрезка: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите выход второго отрезка: ");
double b2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("y = " + k1 + " * x + " + b1 + ", y = " + k2 + " * x + " + b2);
Console.WriteLine(k1 + " * x + " + b1 + " = " + k2 + " * x +" + b2);
Console.WriteLine("(" + k1 + " - " + k2 + ")" +  "* x = " + b2 + " - " + b1);
Console.WriteLine("x = (" +  b2 + " - " + b1 + ")/(" + k1 + " - " + k2 + ")");
Console.WriteLine("y = " + k1 + " * x + " + b1);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine("=========================");

Console.Write($"Точка пересечения по координатам: {x} {y}");
*/

/*
//Показать числа Фибоначчи

Console.Write("До какого числа считать ряд Фибоначчи? - ");
double lastnumber = double.Parse(Console.ReadLine()!);
double first = 0;
double second = 1;
double fibonachi = 0;
double count = 1;

while(count <= lastnumber)
{
fibonachi = first + second;
second = first;
first = fibonachi;
count++;
Console.WriteLine(fibonachi);
}
*/

//Написать программу масштабирования фигуры
Console.Write("Введите длину фигуры: ");
double a1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите ширину фигуры: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите, на сколько хотите увеличить  фигуру: ");
double k = double.Parse(Console.ReadLine()!);

double x = a1 * k;
double y = b1 * k;

Console.WriteLine("=========================");

Console.Write($"Длина и ширина равна: {x} {y}");