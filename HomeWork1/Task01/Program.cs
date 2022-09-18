// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = int.Parse(Console.ReadLine());

if(numberA == numberB)
{
   Console.Write("Первое число равно второму, и равно: "); 
   Console.WriteLine(numberA);
}
else
    if(numberA > numberB)
    {
    Console.Write("Большее число: "); 
    Console.WriteLine(numberA);
    Console.Write("Меньшее чило: "); 
    Console.WriteLine(numberB);
    }
    else
    {
    Console.Write("Большее число: "); 
    Console.WriteLine(numberB);
    Console.Write("Меньшее чило: "); 
    Console.WriteLine(numberA);
    }
