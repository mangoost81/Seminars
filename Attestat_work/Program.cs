// // // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// // // Использовать рекурсию, не использовать циклы.


// // Console.WriteLine("Введите первое число ");
// // int M = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Введите второе число ");
// // int N = Convert.ToInt32(Console.ReadLine());

// // //Console.WriteLine($"{M} {N}");



// // void GetNums(int start, int stop)
// // {
// //     System.Console.WriteLine(start);

// //     if(start == stop)
// //     {
// //         return;
// //     }

// //     GetNums(start+1, stop);

// // }

// // GetNums(M,N);



// // Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// // Даны два неотрицательных числа m и n.

// Console.Write("Введите значение m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение n:");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     } 
//     else if (n == 0)
//     {
//         return akkerman(m - 1, 1);
//     }
//     else
//     {
//         return akkerman(m - 1, akkerman(m, n - 1));
//     } 
// }

// Console.Write(akkerman(m, n));



// // Задайте произвольный массив. 
// // Выведете его элементы, начиная с конца. 
// // Использовать рекурсию, не использовать циклы.

int[] array = new int[10];

void NewArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();

}



void Elements(int[] arr,int len)
{

    
    System.Console.Write(arr[len - 1] + " ");
    
    if(len - 1 == 0)
    {
        return;
    }
   
    Elements(arr,len-1);


}
NewArray();
Elements(array,array.Length);



