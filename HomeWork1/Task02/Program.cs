// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int numberС = int.Parse(Console.ReadLine());

int M = (numberA);

if(M < numberB)
{
    M = (numberB);
}   
    else
    {
        M = (numberA);
    }
    if (M < numberС)
    {
        M = (numberС);
    }
else
{
    M = (numberA);
}

  Console.WriteLine("Большее число: ");
  Console.WriteLine(M);
