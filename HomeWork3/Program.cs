//Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 1)
{
    Console.WriteLine("нечетное");
}
else 
{
    Console.WriteLine("четное");
}