// Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].




// int[] array = new int[10];

// for(int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(1,101); 
// }

// int count = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i]>=20 && array[i]<=90)
//     {
//         count = count + 1;
//     }
    
// }
// Console.WriteLine("\t");
// Console.WriteLine("Количество нужных элементов: " + count);



// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

// int[] array = new int[10];

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(); 
// }

// int count = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i]%2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine("\t");
// Console.WriteLine("количество чётных чисел в массиве - " + count);


// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.


// double[] array = new double[10];

// for(int i = 0; i< array.Length; i++)
// {
//     array[i] = new Random().NextDouble() + new Random().Next();
//     Console.Write(array[i]+ " ");
// }

// double min_arr = array[0];
// double max_arr = array[0];

// for(int i = 0; i< array.Length; i++)
// {
//     if(array[i] < min_arr)
//     {
//         min_arr = array[i];
//     }
//     if(array[i] > min_arr)
//     {
//         max_arr = array[i];
//     }
// }

// Console.WriteLine("\t");
// Console.WriteLine("разница между максимальным и минимальным элементов массива = " + (max_arr - min_arr));