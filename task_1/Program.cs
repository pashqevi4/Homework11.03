﻿//Напишите программу, которая на вход принимает трехзначное число, 
//а на выходе показывает вторую цифру этого числа.
int a = new Random().Next(100,1000);
Console.WriteLine(a);
int x = a % 100 / 10;
Console.WriteLine(x);