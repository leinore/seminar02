﻿// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {number}");

int numberA = number/100;
int numberB = number%10;

Console.WriteLine($"{numberA*10 + numberB}");