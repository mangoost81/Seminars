// Пример
// 2 3 4 3
// 4 3 4 1 =>
// 2 9 5 4
// Обсудить этапы решения задачи
// Оформить этапы в виде функций
// 4 3 4 3
// 4 3 4 1
// 2 9 25 4

// int[,] array = new int[3,4];    //Создание двумерного массива

// void CreateArray()              //Заполнение Двумерного массива
// {
// for (int i = 0; i < array.GetLength(0); i++)         //array.GetLength(0)  размер строки 
// {                                                    // array.GetLength(1) размер столбца
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j] = new Random().Next(1,10);
// }
// }
// }

// void PrintArray()                 //Вывод двумерного массива
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {

// System.Console.Write(array[i,j] + " ");
// }
// System.Console.WriteLine();
// }
// System.Console.WriteLine();
// }

// void FindElementsArray()                        // Поиск нужных элементов в массиве и возведение их в квадрат
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// if(i %2 ==0 && j%2==0)
// {
// array[i,j]= array[i,j] * array[i,j];
// }
// }
// }
// }

// CreateArray();
// PrintArray();
// FindElementsArray();
// PrintArray();


// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4


// int[,] array = new int[3, 4];    //Создание двумерного массива

// void CreateArray()              //Заполнение Двумерного массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)         //array.GetLength(0)  размер строки 
//     {                                                    // array.GetLength(1) размер столбца
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray()                 //Вывод двумерного массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElementsArray()                        // Поиск нужных элементов в массиве и их суммирование
// {   int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += array[i,j];
//             }
//         }
//     }
//     Console.WriteLine("Сумма равна - " + sum);
// }

// CreateArray();
// PrintArray();
// FindElementsArray();



// Задание 3. Совместная работа
// Семинар 5. Двумерные массивы
// 20 мин
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 



int[,] array = new int[3, 4];    //Создание двумерного массива
double[] array2 = new double[array.GetLength(0)];

void CreateArray()              //Заполнение Двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)         //array.GetLength(0)  размер строки 
    {                                                    // array.GetLength(1) размер столбца
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray()                 //Вывод двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FindElementsArray()                        // Поиск нужных элементов в массиве и их суммирование
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {

            sum += array[i, j];

        }
        array2[i] = sum/array.GetLength(1);
    }
    
}

void PrintArray2()                 //Вывод массива 
{
    for (int i = 0; i < array2.Length; i++)
    {
        System.Console.Write(array2[i] + " ");
    }
    System.Console.WriteLine();
}

CreateArray();
PrintArray();
FindElementsArray();
PrintArray2();