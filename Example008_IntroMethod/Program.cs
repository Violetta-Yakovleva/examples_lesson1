﻿// СТИХИЙНЫЙ ПОДХОД В РЕШЕНИИ ЗАДАЧИ (найти наибольшее число из 9 чисел)

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 2311;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 313;

// int max = a1;
// if(b1 > max) max = b1;
// if(c1 > max) max = c1;

// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;

// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;

// Console.WriteLine(max);


// РЕШЕНИЕ С ПОМОЩЬЮ ФУНКЦИИ

int a1 = 112543;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2; // не путать местами что нужно присвоить какой переменной!
    if(arg3 > result) result = arg3; // не путать местами что нужно присвоить какой переменной!
    return(result);
}

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

//Эти три строчки можно заменить на одну ниже, просто прописав переменные в скобочках

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); 
Console.WriteLine(max);