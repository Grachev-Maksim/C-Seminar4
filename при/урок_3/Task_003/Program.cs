// Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Найдем расстояние в 2D");

Console.WriteLine("Введите X координату первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y координату первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X координату второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y координату второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

double Lengh = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine(Lengh);
