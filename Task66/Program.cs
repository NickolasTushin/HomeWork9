// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int rec(int a, int b)
{
    if (a == b)
        return b;
    return rec(a + 1, b) + a;
}
Console.WriteLine($" Сумма натуральных элементов от M до N = {rec(m, n)}");