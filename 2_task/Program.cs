﻿//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("ввeдите число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
{
    Console.Write("третьей цифры нет");
}
else
{
    while (n > 1000)
    {
        n = n / 10;
    }
    Console.Write(n % 10);
}