/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;

Console.WriteLine();

void Print(int n, int m){
    Console.WriteLine(n);
    if(n > m) Print(n-1, m);
}
Print(n, m);
