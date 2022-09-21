// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdC (int a)
{
    while (a > 1000) a = a / 10;
    int result = a % 10;
    return result;
    // if (a >= 1000)
    // {
    //     result = a % 100 / 10;
    // }
}
Console.Write ("Введите любое число: ");
int b = Convert.ToInt32(Console.ReadLine());
int Third = ThirdC (b);
if (b < 100)
{
    Console.Write ("У этого числа нет третьей цифры");
}
else
{
    Console.Write ($"Третья цифра этого числа {Third}");
}

