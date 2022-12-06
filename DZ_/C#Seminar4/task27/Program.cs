// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
//  Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите  число ");
int numa = Convert.ToInt32(Console.ReadLine());
int count = count_num(numa);

//вызов функции суммирования числа
int pr = sum_num(numa, count);
Console.WriteLine($"в числе {numa} сумма цифр составляет {pr}");

//функция суммирует цифры в числе
int sum_num(int numa, int count)
{
    int res = 0;
    for (int i = 1; i <= count; i++)
    {
        res = res + (((numa % (steppen(10, i)))) / (steppen(10, i - 1)));
    }
    return res;
}

// функция считает кол-во цифр в числе
int count_num(int num) // тип имя функции (список параметров)
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

//функция возведения в степень
int steppen(int numa, int numb) //определение функции
{ //тело функции
    int result = 1;
    for (int i = 1; i <= numb; i++)
    {
        result = result * numa;
    }
    return result; //возвращаемое зачение
}
