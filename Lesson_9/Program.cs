// Задача 64
// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.
// (M = 1; N = 5. -> "1, 2, 3, 4, 5"; M = 4; N = 8. -> "4, 5, 6, 7, 8")
/*
void ShowNumbers(int m, int n)
{
    if (m != n) ShowNumbers(m, n - 1);
    Console.Write(n + ", ");
}
Console.Write("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M, которое меньше числа N: ");
int userM = Convert.ToInt32(Console.ReadLine());
if (userM < userN)
{
    Console.Write($"M = {userM}; N = {userN}. -> \"");
    ShowNumbers(userM, userN);
    Console.Write("\b\b\"");
}
else Console.WriteLine("M должно быть меньше N");
*/

// Задача 66 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N (M = 1; N = 15. -> 120; M = 4; N = 8. -> 30)
/*
int ShowNumbers(int n, int m)
{
    int result = m;
    if (m != n)
    {
        m++;
        return result += ShowNumbers(n, m);
    }
    else return 0;
}
Console.Write("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M, которое меньше числа N: ");
int userM = Convert.ToInt32(Console.ReadLine());
if (userM < userN)
{
    int result = ShowNumbers(userN, userM);
    Console.Write($"M = {userM}; N = {userN}. -> {result + userN}");
}
else Console.WriteLine("M должно быть меньше N");
*/

// Задача 68 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n (m = 2, n = 3 -> A(m, n) = 9).
/*
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m != 0 && n != 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}
Console.Write("Введите число M: ");
int userM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());
if (userM >= 0 && userN >= 0)
{
    int result = Akkerman(userM, userN);
    Console.Write($"m = {userM}, n = {userN} -> A({userM}, {userN}) = {result}");
}
else Console.Write("M и N должны быть неотрицательными");
*/