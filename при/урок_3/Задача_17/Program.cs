// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
try
{
Console.WriteLine("Введите координату Х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());
Checkkoord(x,y);
}
catch
{
    Console.WriteLine("ggggg");
}

void Checkkoord(int x, int y)
{
    if (x>0 && y>0) Console.WriteLine("это четверть № 1");
    else if (x>0 && y<0) Console.WriteLine("это четверть № 4");
    else if (x<0 && y>0) Console.WriteLine("это четверть № 2");
    else if (x<0 && y<0) Console.WriteLine("это четверть № 3");
    else Console.WriteLine("точка находится на координатной оси");
}