// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("Напишите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Квадрат чисел равен: ");

if (N < 0) N = -N;
else if (N == 0) Console.WriteLine("0 ");
for (int i = 1; i <= N; i++)
{
    int sqrt = (i * i);
    Console.Write($"{sqrt} ");
}
