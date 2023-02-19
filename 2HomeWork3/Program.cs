// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber > 0 && dayNumber < 8)
{
if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("это выходной день");
}
if (dayNumber >= 1 && dayNumber <= 5)
{
    Console.WriteLine("это будний день");
}
}
else
{
    Console.WriteLine("это не день недели");
}
