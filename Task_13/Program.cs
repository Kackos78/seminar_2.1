﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число для нахождения его третьей цифры: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] Third = new int[number.Lenght]
