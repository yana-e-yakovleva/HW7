﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Введите элементы через пробел  ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(i => i > 0);
Console.WriteLine($"Кол-во элементов больше нуля: {count}");