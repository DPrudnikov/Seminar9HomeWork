//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

int StopNum = 1;

Console.WriteLine(PrintNumbers (N, StopNum));

string PrintNumbers(int num1, int num2)
{
    if(num1 == num2)
    {
         return num2.ToString();
    }
    return (num1 + " " + PrintNumbers(num1-1, num2));
}