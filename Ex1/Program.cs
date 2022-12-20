int x = new Random().Next(10, 100);// от 10 до 99
Console.WriteLine(x);
int des = x/10;
int first = x % 10;
if (des > first)
{
    Console.WriteLine(des);
}
else
{
   Console.WriteLine(first); 
}
Console.WriteLine(number / 10 > number % 10 ? // if (number / 10 > number % 10)
number / 10 : // печатаем number / 10
number % 10 );// else печатаем number % 10

