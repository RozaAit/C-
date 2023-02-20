Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int lengtA = number.Length;

if (lengtA == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine("палиндром");
    }
    else
    {
        Console.WriteLine("не палиндром");
    }
}
else
{
    Console.WriteLine ("число не является пятизначным"); 
}