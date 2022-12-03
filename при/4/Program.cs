Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int div=num/100;
int div2=(num-div*100)/10;
int rez=num-div*100-div2*10;
if (num<100)
{
    Console.WriteLine("Не трехзначное число");
}
else if (num<1000)
{
   Console.WriteLine($"{rez}");
}
else {Console.WriteLine("Не трехзначное число");}