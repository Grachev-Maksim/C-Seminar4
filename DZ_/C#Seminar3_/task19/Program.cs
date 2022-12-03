// Задача 19
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
//  Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0)
        num = num * (-1);
    double baseten = Math.Log10(num);
    int temp = Convert.ToInt32(Math.Truncate(baseten)) + 1;
    if (temp != 5)
        Console.WriteLine("Число не является пятизначным ");
    else
    {
        int numleft = num / 1000;
        int numright = num % 100;
        numright = numright % 10 * 10 + numright / 10;
        if (numleft == numright)
            Console.WriteLine($"Введённое число {num} палиндром");
        else
            Console.WriteLine($"Введённое число {num} не палиндром");
    }
}
catch
{
    Console.WriteLine("ERROR");
}
