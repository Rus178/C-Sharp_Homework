// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа(456 -> 5, 782 -> 8, 918 -> 1)

// int Num(int num)
// {
//     int dec = num % 100 / 10;
//     return dec;
// }
// Console.Write("Введите 3-значное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result;
// if (num > 99 && num < 1000)
// {
//     result = Num(num);
//     Console.Write($"Вторая цифра числа {num}: {result}");
// }
// else Console.Write($"Число {num} не 3-значное");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет(78 -> третьей цифры нет, 32679 -> 6)

// int Third(int num)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     int third = num % 10;
//     return third;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result;
// if (num > 99)
// {
//     result = Third(num);
//     Console.Write($"Третья цифра числа {num}: {result}");
// }
// else Console.Write("Третьей цифры нет");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным(7 -> да, 1 -> нет)

// void DayOfTheWeek(int day)
// {
//     if (day < 6)
//         Console.Write($"{day}-й день недели не выходной");
//     else Console.Write($"{day}-й день недели выходной");
// }
// Console.Write("Введите число от 1 до 7: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day > 0 && day < 8)
//     DayOfTheWeek(day);
// else Console.Write("Вы ввели некорректное число");
