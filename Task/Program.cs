/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
try
{
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());
double[] array = {num1,num2,num3};                  //добавил массив
int i=0;
double max = array[i];                              //Принял первое число массива как самое большое
while (i < array.Length)
{
    if (array[i] > max)
    {
        max=array[i];
    }
    i++;
}
Console.WriteLine("Самое большое число " + max);
}
catch
{
    Console.WriteLine("Введено некорректное число");
}