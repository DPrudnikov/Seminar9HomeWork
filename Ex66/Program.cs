﻿//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число 1 ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNum(first, second));

int SumNum(int num1, int num2)
{
   
    if(num1==num2)
    {
        return num2;
    }
    return (num1 + SumNum(num1+1,num2));

}
