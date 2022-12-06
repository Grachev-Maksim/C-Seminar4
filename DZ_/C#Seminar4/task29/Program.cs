// Задача 29: Напишите программу,
//  которая задаёт массив из 8 элементов с клавиатуры и
//   выводит массив на экран.

int size = 8;
int[] array = CreateArray(size);
PrintArray(array);

// создание массива
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

// вывод на экран
void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
