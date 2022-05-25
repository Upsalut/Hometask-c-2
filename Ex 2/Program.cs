//По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Enter first number:");
int number1= int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int number2= int.Parse(Console.ReadLine());
if (number2*number2==number1)
{
    Console.WriteLine("The " + (number1) + " is square of " + (number2));
}
else if (number1*number1==number2)
{
    Console.WriteLine("The " + (number2) + " is square of " + (number1));
}
else
{ 
 Console.WriteLine("There are no squares of numbers");
}