//Напишите программу, которая показывает третью цифру заданного числа 
//или сообщает, что третьей цифры нет
int a = new Random().Next(1,100000000);
Console.WriteLine(a);
if (a < 100)
{
    Console.WriteLine("There's no third digit");
   }
  
if ((a < 1000)&&(a>100))
{
    int x = a % 10;
    Console.WriteLine(x);
}

if (a > 1000)
{
    while (a > 999)
    {
        a = a / 10;
    }
    int y = a % 10;
    Console.WriteLine(y);
}
