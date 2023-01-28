// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] array = new int[11];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + " ");
}

 