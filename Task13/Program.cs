// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdC (int a)
{
    int result = a % 10;
    if (a >= 1000)
    {
        result = a % 100 / 10;
    }
    return result;
    
}
Console.Write ("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int Third = ThirdC (a);
if (a < 100)
{
    Console.Write ("У этого числа нет третьей цифры");
}
else
{
    Console.Write ($"Третья цифра этого числа {Third}");
}

