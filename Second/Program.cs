// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да

Console.Write("Введите число > "); // Вывод приглашения ввода
string firstValue = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int value1 = Convert.ToInt32(firstValue); // Преобразование строки в число
Console.Write("Введите второе число > "); // Вывод приглашения ввода
string secondValue = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int value2 = Convert.ToInt32(secondValue); // Преобразование строки в число

int squareValue = value1 * value1; // вычисление квадрата
if(value2 == squareValue)
{
    System.Console.WriteLine($"Число {value1} является квадратом {value2}");
}
else
{
    System.Console.WriteLine($"Число {value1} не является квадратом {value2}");
}
