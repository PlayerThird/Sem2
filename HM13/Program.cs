//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int x = new Random().Next(1, 100000);// от 100 до 999
int a = x / 100;
a = a % 10;
Console.WriteLine(x);
if (a == 0)
{
    Console.WriteLine("У числа нет 3й цифры");
}
else
{
    
    Console.Write(a);
}
