// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int number)
{
    if(number == M - 1)
    {
        return;
    }
    PrintNumbers(number - 1);
    Console.Write(number + " ");
}

PrintNumbers(N);
