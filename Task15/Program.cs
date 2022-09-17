// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write ("Введите цифру от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 7 || a < 1) Console.Write ("Введено неверное значение");
else switch (a)
{
    case 6:
    Console.Write ("Выходной");
    break;
    case 7:
    Console.Write ("Выходной");
    break;
    default: Console.Write ("Увы, это не выходной");
    break;
}