﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да

Console.WriteLine("Введите число: ");
string N = Console.ReadLine();

    if (N[0] == N[4] && N[1] == N[3])
    {
        Console.WriteLine($"{N} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{N} - Не палиндром");
    }

