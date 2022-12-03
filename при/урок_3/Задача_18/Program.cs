try
{
Console.WriteLine("Введите координату Х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());
Checkkoord(x,y);
string res=Checkkoord2(x,y);
Console.WriteLine(res);
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
string Checkkoord2(int x, int y)
{
string res; 
    if (x>0 && y>0) res ="это четверть № 1";
    else if (x>0 && y<0) res ="это четверть № 4";
    else if (x<0 && y>0) res ="это четверть № 2";
    else if (x<0 && y<0) res ="это четверть № 3";
    else res ="точка находится на координатной оси";
    return res;
}