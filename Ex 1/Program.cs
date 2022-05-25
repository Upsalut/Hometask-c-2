//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int day=new Random().Next(1,7);
Console.WriteLine(day);
if (day == 6 || day==7)
{
    Console.WriteLine("It is weekend");
}
else
{
    Console.WriteLine("It is not weekend");
}