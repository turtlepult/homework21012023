using Internal;
using System;
// Найти сумму чисел от 1 до А
int n = new Random().Next(10, 100);
int sum = 0;
Console.WriteLine("Сумма числел от 1 до " + n);

for (int i = 1; i <= n; i++)
{
    sum = sum + i;
}
Console.Write(sum);