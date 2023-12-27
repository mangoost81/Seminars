
// // char [] elements = new char[]{'$', '2' 'f' 'p'};   //задаем массив из строк
// // int [] nums = new int[]{4,-21,55};   //задаем массив чисел
// // string str = "$2fp";                 //аналогично массиву строк
// // System.Console.WriteLine(str[2]);   


// // Задайте массив символов (тип char []). Создайте строку из
// // символов этого массива.
// // Указание
// // Конструктор строки вида string(char []) не использовать.

// char[] elements = new char[] { 't', '8', '4' };

// string GetStringFromArray()
// {
//     string str = "";

//     for (int i = 0; i < elements.Length; i++)
//     {
//         //str = str + elements[i];
//         str += elements[i];
//     }
//     return str;
// }

// // string result = GetStringFromArray();
// // System.Console.WriteLine(result);

// System.Console.WriteLine(GetStringFromArray());



// // На основе символов строки (тип string) сформировать массив
// // символов (тип char[]). Вывести массив на экран.
// // Указание
// // Метод строки ToCharArray() не использовать.
// // Пример
// // “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// System.Console.WriteLine("Введите строчку");
// string userInput = Console.ReadLine();

// char[] elements = new char[userInput.Length];

// void GetArrayFromString()
// {
//     for (int i = 0; i < elements.Length; i++)
//     {
//         elements[i] = userInput[i];
//     }



// }

// void PrintArray()
// {
//     foreach (char item in elements)             //перебирает элементы массива
//     {
//         Console.Write(item + " ");
//     }
//     // for (int i = 0; i < elements.Length; i++)
//     // {
//     // System.Console.Write(elements[i] + " ");
//     // }
// }

// GetArrayFromString();
// PrintArray();



// // Считать строку с консоли, состоящую из латинских
// // букв в нижнем регистре. Выяснить, сколько среди
// // введённых букв гласных.
// // Пример
// // “hello” => 2
// // “world” => 1

// System.Console.WriteLine("Введите строчку");
// string userInput = Console.ReadLine();

// string vowels = "aeiyuo";

// int GetCountVowels()
// {
//     int count = 0;

//     for (int i = 0; i < userInput.Length; i++)
//     {
//         for (int j = 0; j < vowels.Length; j++)
//         {
//             if (userInput[i] == vowels[j])
//             {
//                 count++;
//                 // count=count+1;
//             }
//         }
//     }
//     return count;
// }
// System.Console.WriteLine(GetCountVowels());