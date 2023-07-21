/* Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 
*/

/* Функция Аккермана определяется рекурсивно для неотрицательных целых чисел m и n следующим образом:

A(m,n)=           n+1, m=0;
A(m-1,1),         m>0,n=0;
A(m-1, A(m, n-1)),m>0, n>0 
*/

Console.WriteLine("Input number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number n: ");
int n = Convert.ToInt32(Console.ReadLine());


int AckFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckFunction(m - 1, 1);
    else return AckFunction(m - 1, AckFunction(m, n - 1));
}

Console.Write($"Ackerman function for {m} and {n} is {AckFunction(m, n)}.");