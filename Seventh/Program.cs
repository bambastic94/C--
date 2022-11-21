// Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение.
// 1 -> 1
// 2 -> 0.5
// 0.25 -> 4

Console.Write("Введите число > "); 
string inputValue = Console.ReadLine(); 
double N = Convert.ToDouble(inputValue); 

double value = 1 / N; 
System.Console.WriteLine("Обратное число " + N + " равен " + value);
