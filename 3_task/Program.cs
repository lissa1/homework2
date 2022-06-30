//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("ввeдите число от 1 до 7 ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 5 && n < 8)
{
    Console.WriteLine("это выходной");
}
else if (n > 7)
{
    Console.WriteLine("это не день недели");
}
else
{
    Console.WriteLine("это будний день");
}

    