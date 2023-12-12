// Console.WriteLine("ВВедите число, квадрат которого хотите получить. ");



// //Преобразование строки в число (ввод всегда происходит строкой)
// int num = Convert.ToInt32(Console.ReadLine());  

// Console.WriteLine($"Квадрат числа {num} равен {num*num}");

// //Вывод квадрата введенного числа
// //Console.WriteLine(num*num);  




// 1. Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2 * num2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());


//Если проверяем одну переменную, но после первого if идет else if.  Если несколько, то просто if

// if(num == 1)
// {
// Console.WriteLine("Понедельник");
// }
// else if(num == 2)
// {
// Console.WriteLine("Вторник");
// }
// else if(num == 3)
// {
// Console.WriteLine("Среда");
// }
// else if(num == 4)
// {
// Console.WriteLine("Четверг");
// }
// else if(num == 5)
// {
// Console.WriteLine("Пятница");
// }
// else if(num == 6)
// {
// Console.WriteLine("Суббота");
// }
// else if(num == 7)
// {
// Console.WriteLine("Воскресенье");
// }
// else
// {
// Console.WriteLine("Такого дня нет");
// }


// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все
// целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int negNum= num *-1;

// while(negNum<=num)
// {
// Console.WriteLine(negNum);
// negNum= negNum+1;
// }

// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю
// цифру этого числа._x000b_ 456 -> 6_x000b_ 782 -> 2_x000b_ 918 -> 8

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = num %10;
// Console.WriteLine(result);