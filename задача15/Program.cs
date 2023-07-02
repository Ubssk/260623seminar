// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int Digit = Convert.ToInt32(Console.ReadLine());
while (Digit > 7)
{
    Console.WriteLine("Такого дня недели не существует");
    break;
}
while (Digit < 6)
{
    Console.WriteLine("Рабочий день");
    break;
}
while (Digit == 6 || Digit == 7)
{
    Console.WriteLine("Выходной");
    break;
}
