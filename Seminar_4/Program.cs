// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2


// тип возвращаемого значения + название + () + {}


// Console.WriteLine("Введите размер массива:");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array = new int[num];

// void PrintArray()
// {
//     for(int i = 0;  i < array.Length; i++)
// {
//         array[i] = new Random().Next(10,101);
//         Console.Write(array[i] + " ");
// }

// }



// int FindNumber()
// {
//     int count_number = 0;

//     for(int i = 0;  i < array.Length; i++)
//     {
//         if(array[i]%10 == 1 && array[i]%7 ==0)
//         {
//         count_number++;
//         }
    
//     }
//     return count_number;
// }


// PrintArray();
// int newNum = FindNumber();

// System.Console.WriteLine("\t"); 
// System.Console.WriteLine(newNum);

//Задача 2
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231



// Console.WriteLine("Введите размер массива:");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array = new int[num];

// void PrintArray()
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// int GetNumber()
// {
//     string numberPerson = "";

//     for(int i = 0; i < array.Length; i++)
//     {
//         numberPerson = numberPerson + array[i];
//     }
//     int result = Convert.ToInt32(numberPerson);
//     return result;
// }

// PrintArray();
// int newNum = GetNumber();

// System.Console.WriteLine("\n"+newNum);


// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3


Console.WriteLine("Введите размер массива:");
int num = Convert.ToInt32(Console.ReadLine());

int [] array = new int[num];

void PrintArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10,100);
        System.Console.Write(array[i] + " ");

    }
    System.Console.WriteLine("");
}


int GetNumber()
{
    
    int countnumber = 0;
    for(int i = 0; i < array.Length; i++)
    {
        bool isfind = false;
        for(int j = 2; j < array[i];j++)
        {
            if(array[i]%j == 0)
            {
                isfind = true;
            }
        }

        if(isfind == false)
        {
            countnumber++;
        }
    }
    return countnumber;
}

PrintArray();
int newNum = GetNumber();

System.Console.WriteLine(GetNumber());