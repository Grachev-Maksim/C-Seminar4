// адача 10: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого числа.
//Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное  число"); //log
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
    num = num * (-1);
int temp = 0;
double div = 0;
double baseten = Math.Log10(num);
temp = Convert.ToInt32(Math.Truncate(baseten));
if (temp != 2)
{
    Console.WriteLine("число не соответствует требованиям");
}
else
{
    div = num % (Math.Pow(10, temp));
    if (temp > 1)
    {
        div = (div - div % (Math.Pow(10, temp - 1))) / Math.Pow(10, temp - 1);
    }
    Console.WriteLine($"{Convert.ToInt32(div)}");
}
