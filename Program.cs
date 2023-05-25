//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели: ");
int num_day = int.Parse(Console.ReadLine());

if (num_day >=1 && num_day <=7)
{
    if (num_day == 6 || num_day == 7)
    {
        Console.WriteLine($"{num_day} - выходной");
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }
}
else 
{
    Console.WriteLine($"{num_day} Такого дня недели нет");
}