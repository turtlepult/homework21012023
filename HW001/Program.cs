//Найти кубы чисел от 1 до N
int n = new Random().Next(1, 10);
Console.WriteLine(n);
for (int i = 1; i<=n; i++)
{
    Console.Write(i + " - ");
    int result = i * i * i;
    Console.WriteLine(result);
}