// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int[] array = {1,2,3,4,5,6,7,8,9};
int diff = 0;
int max = array[0];
int min = array[0];

for (int j = 0; j <array.Length; j++)
{
    if (array[j] > max)
         {
             max = array[j];
         }
    
    if (array[j]<min)
        {
              min = array[j];
        }
}
diff = max - min;
Console.WriteLine(diff);
