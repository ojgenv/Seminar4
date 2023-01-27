/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int getSum(int a)
{
    int i = 0;    
    while(a > 0)
    {
        i = i + a % 10;
        a = a / 10;
    }    
    return i;
}

Console.WriteLine("Введите число");
Console.WriteLine(getSum(Convert.ToInt32(Console.ReadLine())));