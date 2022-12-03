// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да
// // 
Console.WriteLine("Введите целое число a");
int numa = Convert.ToInt32(Console.ReadLine());
if (numa%7==0 && numa%23==0)
{
    Console.WriteLine($"{numa} число кратно 7 и 23");
}
else 
{
    Console.WriteLine($"{numa} число не кратно 7 и 23");
}