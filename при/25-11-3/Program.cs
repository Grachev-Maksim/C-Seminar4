// Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите целое число a");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число b");
int numb = Convert.ToInt32(Console.ReadLine());
int oct = numa%numb;
if (oct==0)
{
    Console.WriteLine("числа кратные");
}
else 
{
  Console.WriteLine("числа не кратные");
  Console.WriteLine($"остаток {oct}");
}