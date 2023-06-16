// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number > 1000 || number < 100)
{
    System.Console.Write("Ошибка! Введите трехзначное число:");
    number = Convert.ToInt32(Console.ReadLine());
}

int num1 = number / 100;
int num3 = number % 10;

int num2 = (number - num1 * 100 - num3) / 10 ;

System.Console.WriteLine(num2);