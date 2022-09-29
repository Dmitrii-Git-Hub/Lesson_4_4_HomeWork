// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DegreeOfNumber(int number, int degree)
{
    int result = number;
    for (int i = 1; i < degree; i++)
    {
        result = result * number;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень числа: ");
int deg = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine(num + " в " + deg +  " степени = " + DegreeOfNumber(num, deg));
