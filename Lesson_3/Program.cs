// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом (14212 -> нет, 12821 -> да, 23432 -> да).
/*
void Palindrome(int uN)
{
    int number1 = uN / 10000;
    int number2 = uN / 1000 % 10;
    int number4 = uN / 10 % 10;
    int number5 = uN % 10;
    if (number1 == number5 && number2 == number4)
        Console.Write("да.");
    else Console.Write("нет.");
}
Console.Write("Введите пятизначное положительное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber > 9999 && userNumber < 100000)
{
    Console.Write($"{userNumber} -> ");
    Palindrome(userNumber);
}
else Console.WriteLine("Введено некорректное значение");
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве (A(3, 6, 8), B(2, 1, -7) -> 15.84).
/*
double DistanceABC(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distABC = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distABC;
}
Console.Write("Введите X координату точки A: ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки A: ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки A: ");
int zAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X координату точки B: ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки B: ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки B: ");
int zBcoord = Convert.ToInt32(Console.ReadLine());
double distanceABC = DistanceABC(xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);
Console.WriteLine($"Дистанция между точкой A и точкой B = {distanceABC:f2}");
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N (3 -> 1, 8, 27.; 5 -> 1, 8, 27, 64, 125.).
/*
void Cubes(int uN)
{
    int current = 1;
    while (current <= uN)
    {
        double res = Math.Pow(current, 3);
        Console.Write($"{res}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}
Console.Write("Введите целое положительное число: ");
int user_number = Convert.ToInt32(Console.ReadLine());
if (user_number >= 1)
{
    Console.Write($"{user_number} -> ");
    Cubes(user_number);
}
else Console.WriteLine("Введено некорректное значение");
*/