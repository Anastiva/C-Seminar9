// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void PrintNumbers(int number)
{
    if(number == 0)
    {
        return;
    }
    PrintNumbers(number - 1);
    Console.Write(number + " ");
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumbers(N);


