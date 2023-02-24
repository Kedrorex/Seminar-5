// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

System.Console.WriteLine("Введите поисковое число: ");
int gis = Convert.ToInt32(Console.ReadLine());


bool Gis(int [] arr)
{
bool number = false;
for (int i = 0; i < arr.Length; i++)
{
  if(gis == arr[i])
  {
    number = false;
    break;
  }
  else
  {
    number = true;
  }
}
return number;
}

if (Gis(array))
{
  System.Console.WriteLine("Число не имеется");
}
else
{
 System.Console.WriteLine("Число имеется");
}

/*
//Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < array.Length; i++)
{
    if(array[i] = number)
    {
        sumPositive+=array[i];
    }
    else
    {
        sumNegative+=array[i];
    }
}
System.Console.WriteLine($"Сумма положительных = {sumPositive}, а отрицательных = {sumNegative}");*/