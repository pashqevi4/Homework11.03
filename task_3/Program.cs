Console.WriteLine("Enter day of the week");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 7)
{
    Console.WriteLine("There's no such a day");
}
if ((a > 5)&&(a < 8))
{
    Console.WriteLine("Hooray! It's weekend! (YES)");
}
if (a < 6)
Console.WriteLine("Get back to work! (NO)");