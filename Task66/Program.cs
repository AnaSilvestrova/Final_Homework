/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Input first number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int SumOfElements(int m, int n)
{
    if (n == m) return n;
    return SumOfElements(n+1, m) + n;
}

SumOfElements(m, n); // Как решить ошибку Stack overflow? Неправильно заданы границы условия?