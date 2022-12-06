// Задача 26. - HARD необязательная Напишите программу,
// которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4
Console.WriteLine("Введите   число");
double num = Convert.ToDouble(Console.ReadLine()); //Convert.ToDouble(-конвертация в тип данных double -число с точкой(дробное)_число двойной точности
int sum = count_num(num);
Console.WriteLine($"В числе {num} {sum} цифр");

int count_num(double num)
{
    int temp = 0;
    if (num < 0)
        num = num * (-1);
    while (num != Math.Truncate(num))
    {
        num = num * 10;
    }
    if (num == Math.Truncate(num))
    {
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
    }

    return temp;
}
