// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] array = {1,2,3,4,5,6,7,8,9,10};

for (int i = 0; i < array.Length; i++)
{
    int n1 = array[i];
    int n2 = array[array.Length - 1 - i];
    int diff = n1*n2;
    Console.WriteLine(diff);
}