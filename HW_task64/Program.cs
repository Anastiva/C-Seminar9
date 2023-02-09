﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void PrintNumbers(int number, int count)
{
    if(count > number)
    {
        return;      
    }
    else
    {
    PrintNumbers(number, count + 1);
    Console.Write(count + " ");
    } 
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
PrintNumbers(N, count);