//Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Enter a part of coordinate axis:");
int part= int.Parse(Console.ReadLine());
if (part<=0 || part>4)
{
    Console.WriteLine("It is incorrect number, it can be from 1 to 4");
}
else if (part==1)
{
    Console.WriteLine("x>0, y>0");
}
else if (part==2)
{
    Console.WriteLine("x<0, y>0");
}
else if (part==3)
{
    Console.WriteLine("x<0, y<0");
}
else
{ 
 Console.WriteLine("x>0, y<0");
}
