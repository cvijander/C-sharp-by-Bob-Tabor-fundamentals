// See https://aka.ms/new-console-template for more information
Console.WriteLine("Understanding scope ");



string j = "";

for (int i = 0; i < 10; i++)
{
    j = i.ToString();
    Console.WriteLine(i);

    if(i ==9)
    {
        string l =i.ToString();
    }
   // Console.WriteLine(l);
}

Console.WriteLine("Outisde of for " + j);
//Console.WriteLine("outside of for " + k);

HelperMethod();

Car myCar = new Car();
myCar.DoSomething();


//private static string k = "";

static void HelperMethod()
{
    Console.WriteLine("Value from the helper method");
}

class Car
{
    public void DoSomething()
    {
        Console.WriteLine(HelperMethod());
    }

    private string HelperMethod()
    {
        return "Hello world";
    }
}