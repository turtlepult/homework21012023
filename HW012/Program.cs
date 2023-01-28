// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] array = {1,2,3,4,5,6,7,8,9,10};
int count = 0;

  foreach (var item in array)
  {
   int n1 = item;
   int n2 = item;
   int diff = n1*n2;
Console.WriteLine(diff);
  }
 


   
