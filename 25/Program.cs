// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.Clear();
Console.Write("Эта программа возведет первое число, которое вы введете, в степень натурального числа, которое вы введете вторым. Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine());
int B = b;
int result = 1;

if (b<0)
{
    Console.WriteLine($"Второе должно быть натуральным. {b} это не натуральное число. Введите второе число:");
    b = int.Parse(Console.ReadLine());
    B = b;
}

else 
{
while (b!=0)
    {
   result = result*a;
   b = b-1;
   }
Console.WriteLine($"Число {a} в степени {B} равно {result}");
}   