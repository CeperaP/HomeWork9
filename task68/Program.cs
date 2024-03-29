﻿// Задача 68: Напишите программу вычисления 
//функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

ulong M=2;
ulong N=3;

ulong Akkerman(ulong m,ulong n)
{
    if (m==0)return n+1;
    if(m>0 && n==0)return Akkerman(m-1,1);
    if(m>0&&N>0 )return Akkerman(m-1,Akkerman(m,n-1));
    return 0 ;
}

System.Console.WriteLine(Akkerman(M,N));