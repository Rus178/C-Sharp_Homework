// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
//     Console.WriteLine($"Число {num1} больше числа {num2}");
// else
// {
//     Console.WriteLine($"Число {num2} больше числа {num1}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.

// 1 вариант

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2 && num1 > num3)
//     Console.WriteLine($"Число {num1} - максимальное");
// else if (num2 > num1 && num2 > num3)
//     Console.WriteLine($"Число {num2} - максимальное");
// else
//     Console.WriteLine($"Число {num3} - максимальное");

// 2 вариант

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2 > max)
//     max = num2;
// if (num3 > max)
//     max = num3;
// Console.WriteLine($"Число {max} - максимальное");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
//     Console.WriteLine($"Число {num} - четное");
// else
//     Console.WriteLine($"Число {num} - нечетное");

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current_num = 2;
// while (current_num <= num)
// {
//     Console.Write(current_num + " ");
//     current_num += 2;
// }