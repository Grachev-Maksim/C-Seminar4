Console.WriteLine("Введите целое число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B");
int numB= Convert.ToInt32(Console.ReadLine());
if (numA== numB*numB )
{
    Console.WriteLine("первое число является квадратом второго ");
}
else
{
    Console.WriteLine("первое число НЕ является квадратом второго "); 
}