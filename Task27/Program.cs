// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDegeetsInNumber(int number)
{
int sum = number % 10;
while (number / 10 > 0)
    {
        number = number / 10;
        sum = sum + number % 10; 
    }
return sum;
}

Console.WriteLine("Введите число: ");
Console.WriteLine("Сумма цифр в числе: " + SumDegeetsInNumber(Convert.ToInt32(Console.ReadLine())));



