// Напишите программу вычисления модуля числа.
// 2 -> 2
// -3 -> 3
// -7 -> 7

Console.Write("Введите число "); 
string inputValue = Console.ReadLine(); 
int value = Convert.ToInt32(inputValue); 

if(value < 0)
{
    int minusValue = value * -1;
    System.Console.WriteLine("Модуль значения " + value + " равен " + minusValue);
}
else
    System.Console.WriteLine("Модуль значения " + value + " равен " + value);
