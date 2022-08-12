//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a, b, c, max;
//начало программы
Console.WriteLine("Введите три целых числа для сравнения: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    max = a;
 }
else
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("{0} наибольшее число", max);