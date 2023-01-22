// Написать программу вычисления произведения чисел от 1 до N
int n = new Random().Next(1, 10);
int multi = 1;
Console.WriteLine(n);

for (int i = 1; i <= n; i++)
{
    multi = multi * i;
    Console.WriteLine(multi);
}