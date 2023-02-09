void MNArray( int numbers1, int numbers2)
{
    if( numbers1 == numbers2 -1)
    {
        return;
    }
MNArray(numbers1 -1, numbers2);
Console.Write(numbers1 + " ");
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
MNArray(N,M);
