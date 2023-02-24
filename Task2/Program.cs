// // Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные,
//  и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] FillArrayWithRandomNumbers(int length)
{
    int[] arr = new int [length];
    Random rnd = new Random();
    for(int i =0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);

System.Console.WriteLine($"[ {string.Join(", ", array)} ]");

for (int i = 0; i < array.Length; i++)
{
  array[i] = array[i] * (-1);
}

System.Console.WriteLine($"[ {string.Join(", ", array)} ]");