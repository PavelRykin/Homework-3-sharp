/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Найдём расстояние двух точек A и B в 3д пространстве"); // сейчас буду узнавать у пользователя точные координаты точек А и В

Console.WriteLine("Напишите координаты точки А по координате x ");
int ax = int.Parse(Console.ReadLine());

Console.WriteLine("Напишите координаты точки А по координате y ");
int ay = int.Parse(Console.ReadLine());

Console.WriteLine("Напишите координаты точки А по координате z ");
int az = int.Parse(Console.ReadLine());

Console.WriteLine("Теперь обозначим координаты точки B");

Console.WriteLine("Напишите координаты точки B по координате x ");
int bx = int.Parse(Console.ReadLine());

Console.WriteLine("Напишите координаты точки B по координате y ");
int by = int.Parse(Console.ReadLine());

Console.WriteLine("Напишите координаты точки B по координате z ");
int bz = int.Parse(Console.ReadLine());

Console.WriteLine("Расстояние между А и В равно " + find_distance_a_and_b(ax, bx, ay, by, az, bz));

double find_distance_a_and_b(double x1, double x2, double y1, double y2, double z1, double z2) // создаю функцию для нахождения расстояния по имеющимся данным от пользователя
{
    double result1 = x2 - x1;
    double result2 = y2 - y1;
    double result3 = z2 - z1;
    result1 = Math.Pow(result1, 2); // тут возвожу в квадрат полученное число
    result2 = Math.Pow(result2, 2);
    result3 = Math.Pow(result3, 2);
    double result = result1 + result2 + result3; // получаю сумму
    result = Math.Sqrt(result); // возвожу в квадратный корень
    result = Math.Round(result, 2); // сокращаю до двух символов после запятой
    return result;
}
