//Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int remDiv = number % 2;

if (remDiv == 0)
{
System.Console.WriteLine("четное");
}
else 
{
System.Console.WriteLine("не четное");
}