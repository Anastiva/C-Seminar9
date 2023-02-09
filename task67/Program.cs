// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int Sum(int number)
{
    if(number == 0)
    {
        return 0;
    }
    return number%10 + Sum(number/10);
 }

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = Sum(N);
Console.Write(sum);