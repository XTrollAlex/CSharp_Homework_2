// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 1000)
{
    number = number/10;
}

if (number/100 > 0 || number/100 < 0)
{
    Console.Write("Третья цифра введённого числа:  " + number%10);
}
else Console.Write("Число не содержит третьей цифры");