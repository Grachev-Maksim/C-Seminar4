// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня недели");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 6 || num == 7)
    {
        Console.WriteLine($"введеные день № {num} является выходным ");
    }
    else if (num >= 1 && num < 6)
    {
        Console.WriteLine($"введеные день № {num} является рабочим  ");
    }
    else
    {
        Console.WriteLine($"введеное число {num} не является днем недели ");
    }
}
catch
{
    Console.WriteLine("ERROR");
}
