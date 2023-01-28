// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] array = new int[10];
int countPos = 0;
    int countNeg = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 200);
}

for (int i = 0; i < array.Length; i++)
{
    
    if (array[i]%2==0)
    {
        countPos++;
    }
    else
        countNeg++;

}
Console.Write("+ " + countPos + ", - "+ countNeg);