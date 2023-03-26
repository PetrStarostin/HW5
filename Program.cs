//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int VolumeOfEvenNumber(int[] array)
// {
//     int result = 0;
//     for(int i = 0 ; i < array.Length ; i++)
//     {
//         if(array[i]% 2 == 0) result++;
//     }
//     return result;
// }
// int [] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0;  i < size; i++)
//         array[i] = new Random().Next(100, 999 + 1);
    
//     return array;
// }

// void WriteArray(int[] array)
// {
//     for(int i = 0 ; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size);
// WriteArray(array);
// Console.WriteLine($"Четных чисел в массиве: {VolumeOfEvenNumber(array)}");

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
// int SumOfOddIndexNum(int[] array)
// {
//     int result = 0;
//     for(int i = 0 ; i < array.Length ; i++)
//     {
//         if(i % 2 != 0) result += array[i];
//     }
//     return result;
// }

// int [] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0;  i < size; i++)
//         array[i] = new Random().Next(1, 999 + 1);
    
//     return array;
// }

// void WriteArray(int[] array)
// {
//     for(int i = 0 ; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size);
// WriteArray(array);
// Console.WriteLine($"Сумма элементов на нечетных позициях: {SumOfOddIndexNum(array)}");

