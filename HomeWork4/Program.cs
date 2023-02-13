//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i < numberA)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
    }
    i++;
}
if (i <= 1)
{
    Console.WriteLine("нет четных чисел");
}

