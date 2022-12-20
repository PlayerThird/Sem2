// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите число дня недели");
int number = Convert.ToInt32(Console.ReadLine());
int raz = 0;
while (number > 30)// Допустим в идеальном каллендарном дне 30 дней в месяце
{
    number = number - 30;
    raz = raz + 2;
} // уменьшим число в отрезок месяца
while (number > 7)
{
    number = number - 7;
}// уменьшаем число до недели
number = number + raz;
switch (number)
{
    case 1:
    Console.WriteLine("Нет, это Понедельник");
    break;
    case 2:
    Console.WriteLine("Нет, этоВторник");
    break;
    case 3:
    Console.WriteLine("Нет, этоСреда");
    break;
    case 4:
    Console.WriteLine("Нет, этоЧетверг");
    break;
    case 5:
    Console.WriteLine("Нет, этоПятница");
    break;
    case 6:
    Console.WriteLine("ДА, ВЫХОДНОЙ И ЭТО Суббота!");
    break;
    case 7:
    Console.WriteLine("ДА, ВЫХОДНОЙ И ЭТО Воскресенье!");
    break;
}