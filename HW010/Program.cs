﻿//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int[123];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10, 500);
    
        if (10<=array[i] && array[i]<=90)
        {
            count = count + 1;
        }
}
Console.Write (count);
