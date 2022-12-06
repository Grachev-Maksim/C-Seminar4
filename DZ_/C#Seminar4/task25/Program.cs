// Задача 25: Напишите цикл, который принимает на вход два
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите  число А"); //вывод на консоль
int numa = Convert.ToInt32(Console.ReadLine()); //ввод данных
Console.WriteLine("Введите  число Б"); //вывод на консоль
int numb = Convert.ToInt32(Console.ReadLine()); //ввод данных
int res = steppen(numa, numb); //вызов функции

//форматированый вывод
Console.WriteLine($"Ркзультат возведения числа {numa} в степень {numb} = {res}");

//функция

int steppen(int numa, int numb) //определение функции
{ //тело функции
    int result = 1;
    for (int i = 1; i <= numb; i++)
    {
        result = result * numa;
    }
    return result; //возвращаемое зачение
}
