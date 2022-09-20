// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int med (int halfA)
{
    int n = halfA / 10;
    int result = n % 10;
    return result;
}

Console.WriteLine ("Введите трезначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int Srednee = med (a);
Console.WriteLine ($"Среднее цифра числа {Srednee}");