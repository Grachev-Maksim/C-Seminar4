Console.WriteLine("Введите целое число больше 0");
int numA = Convert.ToInt32(Console.ReadLine());
if(numA<0)
{
   Console.WriteLine("Число меньше 0 будут выведены от N до минус N"); 
}
int num=numA*(-1);
while (num<=numA)
{
    Console.Write($"{num} ");
    num++;
}