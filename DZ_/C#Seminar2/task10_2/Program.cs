// адача 10: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого числа.
//Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1
try
{
    Console.WriteLine("Введите трехзначное  число"); // not log
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0)
        num = num * (-1);
    double div = 0;
    if (num < 100 || num >= 1000)
    {
        Console.WriteLine("число не соответствует требованиям");
    }
    else
    {
        div = num % (Math.Pow(10, 2));
        div = (div - div % (Math.Pow(10, 1))) / Math.Pow(10, 1);

        Console.WriteLine($"{Convert.ToInt32(div)}");
    }
}
catch
{
    Console.WriteLine("число не соответствует требованиям");
}
