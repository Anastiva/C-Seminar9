// Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии.

int exponention(int A, int B)
{
    int exp = 1;
    if(B == 0)
    return exp;
    else return exp = A*exponention(A, B-1);
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int exp = exponention(A,B);

Console.WriteLine(exp);