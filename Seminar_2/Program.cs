// Console.WriteLine("ВВедите число"); //Только трехзначное
// int num = Convert.ToInt32(Console.ReadLine());
// if( num > 99 && num < 1000) //  && - и  || - или
// {
//     int num1 = num/100; //Выводим певую цифру
//     int num3 = num%10;  //Выводим последнюю цифру
//     int result = num1*10 + num3;
//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("Число не является трехзначным");
// }


// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine()); //256

// if(num>99 && num<1000) // && - и || - или
// {
// int num2 = num/10 %10; // 5
// int num3 = num % 10; // 6
// int result = 1;

// while(num3>=1)
// {
// result = result *num2;
// num3--;
// // num3 = num3-1;
// }
// Console.WriteLine(result);
// }
// else
// {
// Console.WriteLine("Число не подходит");
// }

//Console.WriteLine(Math.Pow(3,3));


// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 % num2==0)
// {
// Console.WriteLine("да");
// }
// else
// {
// Console.WriteLine("нет, "+ num1%num2);   // Канкатинация
// Console.WriteLine($"нет, {num1%num2}");  // Интерполяция
// }


// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 78126 % 1000 = 126
// 91 => Третьей цифры нет

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num>99)
{
if(num>999)
{
num = num%1000;
}

int result = num/100;
Console.WriteLine(result);
}
else
{
Console.WriteLine("Число не подходит");
}