// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int secondDigit = (Number / 10) - ((Number / 10) / 10 * 10);
Console.WriteLine($"В числе {Number} -> второе число {secondDigit}");