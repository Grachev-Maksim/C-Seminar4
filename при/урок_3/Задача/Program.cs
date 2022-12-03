// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
try
{
Console.WriteLine("Введите координату Х1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2");
int y2 = Convert.ToInt32(Console.ReadLine());
double dim=Checkkoord(x1,y1,x2,y2);
Console.WriteLine($"расстояние {x1},{y1} до {x2},{y2} = {dim}");
}
catch
{
    Console.WriteLine("нужны числа");
}

double Checkkoord(int x1, int y1,int x2, int y2)
{
  double dim = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
  return dim;
}