// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6]
try
{
    Console.WriteLine("Введите  число");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0)
        num = num * (-1);
    int temp = 0;
    double div = 0;
    double baseten = Math.Log10(num);
    if (baseten < 2)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        temp = Convert.ToInt32(Math.Truncate(baseten));
        div = num % (Math.Pow(10, temp - 1));
        if (temp > 2)
        {
            div = (div - div % (Math.Pow(10, temp - 2))) / Math.Pow(10, temp - 2);
        }
        Console.WriteLine($"{Convert.ToInt32(div)}");
    }
}
catch
{
    Console.WriteLine("ERROR");
}
