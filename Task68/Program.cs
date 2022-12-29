// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
while(m < 0)
{
Console.WriteLine("Введите неотрицательное число!!!");
Console.WriteLine("Введите неотрицательное число m: ");
m = Convert.ToInt32(Console.ReadLine());
}
while(n < 0)
{
Console.WriteLine("Введите неотрицательное число!!!");
Console.WriteLine("Введите неотрицательное число n: ");
n = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();

int rec(int a, int b)
 {
     if (a == 0)
         return b + 1;
     if (b == 0)
         return rec(a - 1, 1);
     else 
         return rec(a - 1, rec(a, b - 1));
 }

 Console.Clear();

 Console.WriteLine($"Результат вычислений = {rec (m, n)}");