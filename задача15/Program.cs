Console.Write("Введите число: ");
int Digit = Convert.ToInt32(Console.ReadLine());
int DayOff1 = 6;
int DayOff2 = 7;
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
while (Digit == DayOff1)
{
    Console.WriteLine("Выходной");
    break;
}
while (Digit == DayOff2)
{
    Console.WriteLine("Выходной");
    break;
}
