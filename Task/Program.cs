/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
try
{
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Число " + num1 + " больше, чем число " + num2);
}
else if (num2>num1)
{
    Console.WriteLine("Число " + num2 + " больше, чем число " + num1);
}
else
{
    Console.WriteLine("Числа " + num1 + " и " + num2 + " равны");
}
}
catch
{
    Console.WriteLine("Введено некорректное число");
}
