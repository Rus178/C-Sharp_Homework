// Задача 1
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateNewArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int EvenNumCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int minVal = 100;
int maxVal = 1000;
int[] newArray = CreateNewArray(size, minVal, maxVal);
Console.Write("[");
ShowArray(newArray);
Console.Write($"\b] -> {EvenNumCount(newArray)}");
*/

// Задача 2
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях ([3, 7, 23, 12] -> 19).
/*
int[] CreateNewArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum += array[i];
    }
    return sum;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateNewArray(size, minVal, maxVal);
Console.Write("[");
ShowArray(newArray);
Console.Write($"\b] -> {Sum(newArray)}");
*/

// Задача 3
// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива. Math.Min Math.Max не использовать.
// [3.0 7.1 22.5 2.7 78.8] -> 76.1
/*
double[] CreateNewArray(int size, int minVal, int maxVal)
{
    double[] array = new double[size];
    double num1 = 0;
    double num2 = 0;
    for (int i = 0; i < size; i++)
    {
        num1 = new Random().Next(minVal, maxVal + 1);
        num2 = new Random().NextDouble();
        array[i] = Math.Round(num1 * num2, 2);
    }
    return array;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
double Dif(double[] array)
{
    double min = array[0];
    double max = array[0];
    double dif = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        else if (array[i] > max)
            max = array[i];
    }
    dif = Math.Round(max - min, 2);
    return dif;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
double[] newArray = CreateNewArray(size, minVal, maxVal);
Console.Write("[");
ShowArray(newArray);
Console.Write($"\b] -> {Dif(newArray)}");
*/
