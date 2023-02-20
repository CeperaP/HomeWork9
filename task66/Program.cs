// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Range(int m, int n)
{
    if (n < m) return;
    Range(m, n - 1);
    System.Console.WriteLine(n);
}
int RAnge(int m, int n)
{
    int Sum = 0;
    if (n <= m) return m;
    // Range(m,n-1)
   return  Sum= n+  RAnge(m, n - 1);   
       
}


int M = 4;
int N = 8;

Range(M, N);
System.Console.WriteLine();
System.Console.WriteLine(RAnge(M, N));

