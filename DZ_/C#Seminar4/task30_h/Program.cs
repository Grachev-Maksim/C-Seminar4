// Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке..
//  Далее надо посчитать количество нулей и единиц, 
//  если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.


int size = 8 ;
int[] array = CreateArray(size);
PrintArray(array);
bool res =FindSums(array);
Console.WriteLine($"{res}");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 2);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

bool FindSums(int[] array)
{
    int count_1 = 0;
    int count_0 = 0;
    //цикл проходящийся по всем значениям array, то есть el принимает по очереди все значеиня массива
    //применяется только для просмотра
    foreach (int el in array)
    {
        if (el > 0) count_1  +=1;
        else count_0 += 1;
    }

    Console.WriteLine($"Число единиц в массиве {count_1 }");
    Console.WriteLine($"Число нулей в массиве {count_0 }");
    bool result = false ;
    if (count_1 >count_0)
    result = true ;
    return result ;
}

