/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите пятизначное число, а я проверю является ли оно палиндромом ");
int number = int.Parse(Console.ReadLine()); // сохраняю введённые пользователем данные

if (number < 10000) // проверяю удовлетворяют ли они условию
{
    Console.WriteLine("Введите пожалуйста пятизначное число! ");
    number = int.Parse(Console.ReadLine());
}
else if (number > 99999)
{
    Console.WriteLine("Введите пожалуйста пятизначное число! ");
    number = int.Parse(Console.ReadLine());
}
else
{
    findPalindrom(number); // вызываю функцию для проверки на палиндром
}

int findPalindrom(int num)
{
    int number1 = num / 10000; // разделяю каждое число для переноса их в массив
    int number2 = num / 1000;
    number2 = number2 % 10;
    int number3 = num % 1000;
    number3 = number3 / 100;
    int number4 = num % 1000;
    number4 = number4 % 100;
    number4 = number4 / 10;
    int number5 = num % 1000;
    number5 = number5 % 100;
    number5 = number5 % 10;

    int[] arr = { number1, number2, number3, number4, number5 }; // создаю массив для проверки по индексу

    if (arr[0] == arr[4] && arr[1] == arr[3]) // проверяю является ли число палиндромом
    {
        Console.WriteLine("Это число палиндром");
    }
    else
    {
        Console.WriteLine("Это число не палиндром");
    }
    return num;
}






