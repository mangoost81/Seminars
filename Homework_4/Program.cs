// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// System.Console.WriteLine("Введите количество строк в массиве: ");
// int line = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов в массиве: ");
// int column = Convert.ToInt32(Console.ReadLine());



// int[,] array = new int [line, column];

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


// System.Console.WriteLine("Введите номер строки: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите номер столбца: ");
// int y = Convert.ToInt32(Console.ReadLine());

// void position(int line_num, int column_num)       //Поиск нужного элемента в массиве, если его нет, то извещение об отсутствии.
// {
//     if (line_num > line || column_num > column)
//         Console.WriteLine("такого числа нет.");
//     else
//     {
//         Console.WriteLine(array[line_num, column_num]);
//     }

     
// }
// System.Console.WriteLine();


// CreateArray();
// PrintArray();
// position(x,y);


//  Задайте двумерный массив. 
//  Напишите программу, которая поменяет местами первую и последнюю строку массива.


// System.Console.WriteLine("Введите количество строк в массиве: ");
// int line = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов в массиве: ");
// int column = Convert.ToInt32(Console.ReadLine());



// int[,] array = new int [line, column];

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


// int [,] new_array = new int [line, column];        // Создаем еще один пустой массив

// void ChangeLines()                 //Замена строк двумерного массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i == 0 )
//             {
//                 new_array[i,j] = array[array.GetLength(0)-1 ,j];
//             }
//             if(i == array.GetLength(0)-1)
//             {
//                 new_array[i,j] = array[0 ,j];
//             }
//             if(i != 0 && i != array.GetLength(0)-1)
//             {
//                 new_array[i,j] = array[i ,j];
//             }

//         }
        
//     }
    
// }


// void PrintArray_new()                 //Вывод двумерного массива c заменой строк
// {
//     for (int i = 0; i < new_array.GetLength(0); i++)
//     {
//         for (int j = 0; j < new_array.GetLength(1); j++)
//         {

//             System.Console.Write(new_array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
    
// }


// CreateArray();
// PrintArray();
// ChangeLines();
// PrintArray_new();


// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


System.Console.WriteLine("Введите количество строк в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,] array = new int[x,x];

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

int[] smallarray = new int[x];

void FindSumm()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int Sum = 0;
    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Sum += array[i, j];
        }

         smallarray[i] = Sum;
    }   
    
}

int min_sum()
{
    int min = smallarray[0];
    for(int i = 0; i<smallarray.Length; i++)
    {
        if(smallarray[i]<min)
        {
            min = smallarray[i];
        }
    }
    return min;
}

CreateArray();
PrintArray();
FindSumm();

System.Console.WriteLine(min_sum());