int x = new Random().Next(1, 10);
int y = new Random().Next(1, 10);
Console.WriteLine(x);
Console.WriteLine(y);
int ost = x % y;
Console.WriteLine(ost);
if (x % y != 0)
{
    Console.WriteLine(ost);
}
else
{
    Console.WriteLine("Чудо новогоднее!");
}