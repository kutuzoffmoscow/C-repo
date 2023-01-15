int a = 15;
int b = 30;
int c = 2;


Console.WriteLine("Числа: " + a + ", " + b + ", " + c);

if (a > b)
{
    if(a > c)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(c);
    }
}
else
{
    if(b > c)
    {
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(c);
    }
}