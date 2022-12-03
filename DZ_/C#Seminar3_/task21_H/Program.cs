// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в N-мерном пространстве.
//   Сначала задается N с клавиатуры, потом задаются координаты точек.

try
{
    Console.WriteLine("Введите размерность пространства");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] arr1 = new int[N];
    int[] arr2 = new int[N];
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите {i+1} координату первой точки");
        arr1[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите {i+1} координату второй  точки");
        arr2[i] = Convert.ToInt32(Console.ReadLine());
    }

    double dim = Countdim(arr1, arr2, N);

    Console.WriteLine($"Расстояние между точками = {dim}");
}
catch
{
    Console.WriteLine("Надо было вводить именно целые числа!");
}

double Countdim(int[] arr1, int[] arr2, int n)
{
    double dim = 0;
    for (int i = 0; i < n; i++)
    {
        dim = dim + Math.Pow(arr2[i] - arr1[i], 2);
    }
    dim = Math.Sqrt(dim);
    return dim;
}
