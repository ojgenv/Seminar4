/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int getPow(int a, int b)
{
    int c = 1;    
    for (int i = 1; i <= b; i++)
    {
        c = c * a;
    }    
    return c;
}

Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(getPow(a,b));