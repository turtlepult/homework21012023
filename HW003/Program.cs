// Возведите число А в натуральную степень B используя цикл
int a = 3;
int b = 5;
int res = 1;
for (int i = 0; i < b; i++)
{
    
    res = res * a;
    Console.Write(res + " ");
}