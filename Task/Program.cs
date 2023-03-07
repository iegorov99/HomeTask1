/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
try
{
Console.Write("Введите положительное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i=1;
if (num > 1)
{
    while (i<=num)
    {
        int even = i % 2;
        if (even == 0)
        {
            Console.Write(i + " ");
        }
        i++;
    }
}
else
{
    Console.WriteLine("Введите число больше 1");
}
}
catch
{
    Console.WriteLine("Введено некорректное число");
}
