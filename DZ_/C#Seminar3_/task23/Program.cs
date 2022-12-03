// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
try
{
    Console.WriteLine("Введите число больше нуля");
    int x = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[x];
    if (x <= 0)
        Console.WriteLine("Число меньше нуля");
    else
    {
        for (int i = 1; i <= x; i++)
        {
            arr[i -1] = i * i * i;
            Console.Write($"{arr[i -1]} ");
        }
    }
}
catch
{
    Console.WriteLine("ERROR");
}
