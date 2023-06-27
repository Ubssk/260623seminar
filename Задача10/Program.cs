Console.Write("Введите первое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int secondDigit = Number / 10;
int Digit = (secondDigit / 10) * 10;
int result = secondDigit - Digit;
Console.WriteLine($"В числе {Number} -> второе число {result}");