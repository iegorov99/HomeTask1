/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
try
{
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int ost = num % 2;
if (ost == 0)
{
    Console.WriteLine("Число " + num + " является чётным");
}
else
{
    Console.WriteLine("Число " + num + " не является чётным");
}
}
catch
{
    Console.WriteLine("Введено некорректное число");
}