


int size=5;
int[ ] mass = new int[size];
int nosq=0;
for(int i = 0 ; i < size ; i ++ )
{
    Console.WriteLine($"Введите целое число {i+1}");
    mass[i]= Convert.ToInt32(Console.ReadLine());
}

for(int i = 0 ; i < size ; i ++ ) 
{
    int numa = mass[i];
    for(int j = 0; j < size ;j ++)
    {
        int numb=mass[j];
        if (numa*numa==numb)
        {
            Console.WriteLine($"{numb} является квадратом {numa}");
        }
        else 
        {
            nosq++;
        }

    }
}
if (nosq==size*size)
{
Console.WriteLine("Нет квадратов");
}
