﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
Console.Write("ввeдите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int num1 = num % 100 / 10;   
    //int num1 = num % 10; 
    //int num2 = num / 10;
    //int num3 = num2 % 10;
    //можно еще вот этими формулами решить просто решение будет длинее
    Console.Write("вторая цифра в числе " + num + " равна " + num1);
}
else 
{
    Console.Write("число не трехзначное, попробуйте еще раз");
}