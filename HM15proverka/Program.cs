int y = 1;
for(int i = 1; y < 100; y++)
{
    Console.Write(y);
    Console.Write(" ");
    if (i == 8)
    {
        i = 1;
    }
    switch (i)
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
i++;
}