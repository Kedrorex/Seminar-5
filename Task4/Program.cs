// if %2 !=0, size/2+1

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат
//  в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] FillArrayWithRandomNumbers(int length)
{
    int[] arr = new int [length];
    Random rnd = new Random();
    for(int i =0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 150);
    }
    return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);

System.Console.WriteLine($"[ {string.Join(", ", array)} ]");

System.Console.WriteLine("Введите диапозон от: ");
int numaberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("до: ");
int numaberB = Convert.ToInt32(Console.ReadLine());

int result = 0;

for (int i = 0; array.Length > i; i++)
{
  if(array[i] >= numaberA && array[i] <= numaberB)
  {
    result++;
  }
}

System.Console.WriteLine($"Количество элементов: {result}");