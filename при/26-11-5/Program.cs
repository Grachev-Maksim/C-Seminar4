// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите целое число a");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число b");
int numb = Convert.ToInt32(Console.ReadLine());
if (numa*numa==numb)
{
    Console.WriteLine($"{numb} является квадратом {numa}");
}
else if (numb*numb==numa)
{
    Console.WriteLine($"{numa} является квадратом {numb}");
}
else 
{
    Console.WriteLine($"{numb} и {numa} не является квадратом ");
}