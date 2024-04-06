// See https://aka.ms/new-console-template for more information

int x;
int y;

x= 7;
y = x + 3;
Console.WriteLine(y);

Console.WriteLine("What is your name?");
Console.Write("Type your first name: ");
string myFirstName;
myFirstName= Console.ReadLine();

string myLastName;
Console.Write("Type your last name: ");
myLastName= Console.ReadLine();

Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
