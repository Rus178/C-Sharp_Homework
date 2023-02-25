// Задача 1
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число 
// A в натуральную степень B (3, 5 -> 243 (3⁵); 2, 4-> 16).
/*
int Pow(int a, int b)
{
    int ab = 1;
    for (int i = 1; i <= b; i++)
        ab *= a;
    return ab;
}
Console.Write("Введите первое целое число: ");
int userNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое положительное число: ");
int userNumberB = Convert.ToInt32(Console.ReadLine());
if (userNumberB > 0)
    Console.WriteLine($"{userNumberA}, {userNumberB} -> {Pow(userNumberA, userNumberB)}");
else Console.WriteLine("Введены некорректные значения");
*/

// Задача 2
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в 
// числе (452 -> 11; 82 -> 10; 9012 -> 12).
/*
void Summ(int userNumber)
{
    int summ = 0;
    while (userNumber != 0)
    {
        summ += userNumber % 10;
        userNumber = userNumber / 10;
    }
    Console.Write(Math.Abs(summ));
}
Console.Write("Введите целое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"{userNumber} -> ");
Summ(userNumber);
*/

// Задача 3
// Напишите программу, которая задаёт массив из произвольного колличества 
// элементов и выводит их на экран.
/*
int[] CreateArray(int sizeArray)
{
    int[] randomArray = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
        randomArray[i] = new Random().Next(0, 100);
    return randomArray;
}
void ShowCreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
}
Console.Write("Введите размер массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber > 0)
{
    Console.Write("[");
    int[] newArray = CreateArray(userNumber);
    ShowCreateArray(newArray);
    Console.Write("\b\b]");
}
else Console.WriteLine("Введено некорректное значение");
*/
