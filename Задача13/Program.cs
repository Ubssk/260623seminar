// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int Digit = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (Digit < 100)
{
    Console.WriteLine("Третьего числа нет");   
}
if (Digit > 100 && Digit < 1000)
{
    result = Digit % 10;
    Console.WriteLine(result);
}
if ( Digit > 1000 && Digit / 10 < 1000)
{
    result = Digit / 10 % 10;
    Console.WriteLine(result);
}
if (Digit > 10000)
{
    for (int i = 100; i < Digit; i = i*10)
    {
        while (Digit / i < 999 && Digit / i > 100)
        {
            result = Digit / i % 10;
            Console.WriteLine(result);
            break;
        }
    }
}
