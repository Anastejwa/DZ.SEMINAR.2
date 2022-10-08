//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число" );
int number = int.Parse(Console.ReadLine()!);
while (number > 999)
{
    number /= 10;
}
if (number > 99 && number <= 999)
{
    Console.WriteLine($"Третья цифра числа {number % 10}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}

