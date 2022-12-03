// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой
// разрядности и проверяет, является ли оно палиндромом.
//  Через строку нельзя решать само собой.
Console.WriteLine("Введите число");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0)
        num = num * (-1);
    int temp1 = count_num(num);
    int temp = temp1 / 2;
    int numleft = 0;
    int numright = 0;
    if (temp * 2 < temp1)
    {
        numleft = Convert.ToInt32(num / (Math.Pow(10, temp + 1)));
        numright = Convert.ToInt32(num % (Math.Pow(10, temp)));
    }
    else
    {
        numleft = Convert.ToInt32(num / (Math.Pow(10, temp)));
        numright = Convert.ToInt32(num % (Math.Pow(10, temp)));
    }
    int revnum = 0;
    for (int i = 1; i <= temp; i++)
    {
        revnum =
            Convert.ToInt32(
                ((numright % (Math.Pow(10, i))) / Math.Pow(10, i - 1))
                    * Math.Pow(10, temp - 1 - (i - 1))
            ) + revnum;
    }

    if (numleft == revnum)
        Console.WriteLine($"Введённое число {num} палиндром");
    else
        Console.WriteLine($"Введённое число {num} не палиндром");
}
catch
{
    Console.WriteLine("ERROR");
}
int count_num(int num)
{
    if (num < 0)
        num = num * (-1);
    int temp = 0;
    if (num < 10)
    {
        temp = 1;
    }
    else
    {
        double baseten = Math.Log10(num);

        temp = Convert.ToInt32(Math.Truncate(baseten));
        temp = temp + 1;
    }

    return temp;
}
