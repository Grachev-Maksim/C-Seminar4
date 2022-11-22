// Задача 7 HARD: - илет за 2 необязательных Напишите программу, которая принимает на вход целое 
// число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, 
// что такой цифры нет.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4

Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<0) num=num*(-1);
int temp=0;
double div=0;
double baseten=Math.Log10(num);
if (baseten<2)
{
    Console.WriteLine("В числе меньше 3 знаков");
}
else
{
    temp=Convert.ToInt32(Math.Truncate(baseten));
    div = num%(Math.Pow(10,temp-1));
    if (temp>2)
    {
        div = (div - div%(Math.Pow(10,temp-2)))/Math.Pow(10,temp-2);
    }
    Console.WriteLine($"{Convert.ToInt32(div)}");
}


