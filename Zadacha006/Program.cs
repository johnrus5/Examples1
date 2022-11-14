int number;
Console.Write("Введите число: ");
number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное - ДА");
}
else
{
    Console.WriteLine("Число четное - НЕТ");
}
