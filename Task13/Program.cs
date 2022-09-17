// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write ("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
int Length = b.Length;
 if (Length > 2)
{
    Console.Write ("Третья цифра этого числа - " +b[2]);
}
else
{
    Console.Write ("У этого числа нет третьей цифры");
}