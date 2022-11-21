// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число > "); // Вывод приглашения ввода
string inputValue = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int value = Convert.ToInt32(inputValue); // Преобразование строки в число

int minusValue = value * -1; // вычисление квадрата
System.Console.Write("Ряд чисел ");
while(minusValue <= value)
{
    System.Console.Write(minusValue + " ");
    minusValue++;
}

