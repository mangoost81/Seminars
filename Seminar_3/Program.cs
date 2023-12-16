// // Задайте массив. Напишите программу, которая определяет,
// // присутствует ли заданное число в массиве. Программа
// // должна выдать ответ: Да/Нет.
// // Примеры
// // [1 3 4 19 3], 8 => Нет
// // [-4 3 4 1], 3 => Да

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[5];

// bool isFind =false;

// for(int i =0; i<array.Length; i++)
// {
// array[i] = new Random().Next(0,4); // -191 205
// System.Console.Write(array[i]+ " ");

// if(array[i] == num)
// {
// isFind=true;
// }
// }

// if(isFind == true)
// {
// Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");
// }


// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

int[] array = new int[10];

for(int i =0; i<array.Length; i++)
{
array[i] = new Random().Next(-10,11);
System.Console.Write(array[i]+ " ");
}

Console.WriteLine();

for(int i =0; i<array.Length; i++)
{
array[i] = array[i] *-1;
System.Console.Write(array[i]+ " ");
}