// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write ("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
int Length = b.Length;
if (Length >= 4 || Length < 2)
{
    Console.WriteLine ("Введено неверное значение");
}
else
{
    Console.WriteLine ("Вторая цифра этого числа:"+b[1]);
}
