/*
Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает 
вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
456111 -> 5
78 -> 8
9146548 -> 1
3 -> нет
*/
try
{
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num;
int i = 0;
int mod = 0;
if (num == 0)
{
    Console.WriteLine("Введите число отличное от нуля");
}
else
{
    while (num != 0)
    {
        num = num / 10;
        i++;
    }
    if (i < 2)
    {
        Console.WriteLine("Слишком короткое число");
    }
    else
    {
        while (i > 1)
        {
            if (i == 2)
            {
                mod = num2 % 10;
                Console.Write("Вторая цифра слева: " + Math.Abs(mod));
            }
            i = i - 1;
            num2 = num2 / 10;
        }
    }
}
}
catch
{
    Console.WriteLine("Некорректное число");
}