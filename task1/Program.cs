// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 0;
int NumbersOfDigit(int num)
{
    while (num > 0)
    {
        count++;
        num = num / 10 ;
    }
    return count;
}
Console.WriteLine($"{NumbersOfDigit(number)}");