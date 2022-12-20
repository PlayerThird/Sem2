//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
int x = Convert.ToInt32(Console.ReadLine());
if (x%7 == 0 && x%23 == 0){
    Console.WriteLine("Ауф, оно кратно 7 и 23м");
}
else
{
   Console.WriteLine("уф, оно не кратно ни чему"); 
}