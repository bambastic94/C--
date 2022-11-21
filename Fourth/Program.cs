//  Напишите программу вычисления функции:
// x = f(a) функиця куба

Console.Write("Введите число > "); // Вывод приглашения ввода
string inputValue = Console.ReadLine(); // Ввод строки с терминала (с консоли)
int value = Convert.ToInt32(inputValue); // Преобразование строки в число

int CubeValue = value * value * value; // вычисление квадрата
System.Console.WriteLine("Куб числа" + value + " равен " + CubeValue);
