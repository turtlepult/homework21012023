// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array = new int[11];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10, 100);
        if (i == 0 || i%2==0)
        {
            sum = sum + array[i];
            Console.WriteLine (sum);
        }
}

