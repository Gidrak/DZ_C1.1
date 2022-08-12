//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int M = 1;
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
for (int i = M; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }

}