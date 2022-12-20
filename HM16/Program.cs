// Является ли одно число квадратом другого
Console.WriteLine("Введите 1е число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число");
int y = Convert.ToInt32(Console.ReadLine());
int zx = x*x;
int zy = y* y;
if (x == zy || y==zx){
    Console.WriteLine("Они кратны");
}
else
{
    Console.WriteLine("Они не кратны");
}// просмотреть в какой задачке мы уже решали такое