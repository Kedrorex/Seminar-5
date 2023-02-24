
// Задача 37: Найдите произведение пар чисел в одномерном 
// массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в
//  новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] FillArrayWithRandomNumbers(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}


System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

int newLength = array.Length / 2 + array.Length % 2;
int[] newArray = new int[newLength];

for (int i = 0; i < array.Length / 2; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}

if(array.Length % 2 > 0)
{
    newArray[newArray.Length - 1] = array[array.Length/2];
}
System.Console.WriteLine(string.Join(", ", newArray));



// // ......................................................................
// int[] FillArrayWithRandomNumbers(int length)
// {
//     int[] arr = new int [length];
//     Random rnd = new Random();
//     for(int i =0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(0, 150);
//     }
//     return arr;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWithRandomNumbers(length);
// int[] result = new int[];

// System.Console.WriteLine($"[ {string.Join(", ", array)} ]");


// for (int i = 0; i < array.Length; i++)
// {

// }
// // ........................................................................
// int [] FillArray (int Lenght)
// {
//     int [] arrayFill = new int [Lenght];
//     Random rnd = new Random();
//     for(int i = 0; i < Lenght; i++)
//     {
//         arrayFill [i] = rnd.Next(-9, 10);
//     }
//     return arrayFill;
// }



// int [] MultiplayArray (int [] arrayLenght)
// {
//     int lenghtNewLenght = 1;

//     if (arrayLenght.Length%2 == 0)
//     {
//         lenghtNewLenght = arrayLenght.Length/2;
//     }
//     else
//     {
//         lenghtNewLenght = arrayLenght.Length/2+1;
//     }

//     int [] multiArray = new int [lenghtNewLenght];

//     for(int i = 0; i < lenghtNewLenght; i++) // 0, 1, 2
//     {
//        multiArray [i] = arrayLenght[i]*arrayLenght[arrayLenght.Length-1-i];
//     }
//     return multiArray;
// }

// Console.WriteLine("Enter your length array");
// int lenghtArraY =   Convert.ToInt32(Console.ReadLine());
// int [] numberArray = FillArray (lenghtArraY);
// Console.WriteLine(string.Join(", ", numberArray));
// int [] convertnumberArray = MultiplayArray(numberArray);
// Console.WriteLine(string.Join(", ", convertnumberArray));

