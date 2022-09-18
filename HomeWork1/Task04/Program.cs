 // Напишите программу, которая на вход принимает число (N), 
 // а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число больше 1:");
int num = int.Parse(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("Введено некорректное число!");
}
else
{
    for (int i = 2; i <= num; i = i + 2)
    Console.Write($"{i} ");
    Console.WriteLine(" ");
}