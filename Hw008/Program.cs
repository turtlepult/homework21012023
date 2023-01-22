// Определить, присутствует ли в заданном массиве, некоторое число
Console.WriteLine("Введите число которое ищем: ");
int s = int.Parse(Console.ReadLine() ??"0");

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
        if (array[i] == s)
        {
          Console.WriteLine("В массиве есть введеное вами число! B его индекс в массиве: " + i);
        }
}
for (int i = 0; i < array.Length; i++)
{
   Console.Write(array[i] + " ");
}