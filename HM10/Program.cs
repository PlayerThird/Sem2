//: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int x = new Random().Next(100, 1000);// от 100 до 999
int a = x / 10;
a = a % 10;
Console.WriteLine(x);
Console.Write(a);
//Console.Write(b);