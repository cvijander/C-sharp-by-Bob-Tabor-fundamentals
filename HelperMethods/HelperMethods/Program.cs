// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("The name game");



Console.Write("Ehat is your first  name? ");
string firstName = Console.ReadLine();

Console.Write("What is your last name? ");
string lastName = Console.ReadLine();

Console.Write("In what city were you born? ");
string city= Console.ReadLine();

/*
char[] firstNameArray = firstName.ToCharArray();
Array.Reverse(firstNameArray);

char[] lastNameArray = lastName.ToCharArray();
Array.Reverse(lastNameArray);

char[] cityArray = city.ToCharArray();
Array.Reverse(cityArray);

string result = "";

foreach (char item in firstNameArray)
{
    result += item;
}

result += " ";

foreach (char item in lastNameArray)
{
    result += item;
}

result += " ";

foreach (char item in cityArray)
{
    result += item;
}



Console.WriteLine(result);

*/


/*
string reversedFirstName=  ReverseString(firstName);
string reversedLastName = ReverseString(lastName);
string reversedCity =  ReverseString(city);
*/

DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));



static string ReverseString(string message)
{
        
    char[] messageArray = message.ToCharArray();
    Array.Reverse(messageArray);
    return String.Concat(messageArray);   
    
}

static void DisplayResult(string reversedFirstName,string reversedLastName, string reversedCity )
{
    Console.Write("Result: ");
    Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedCity));

}

 static void DisplayResult1(string reversedFirstName, string reversedLastName)
{
    Console.Write("Result: ");
    Console.Write(String.Format("{0} {1} ", reversedFirstName, reversedLastName));

}

/*
static void Print ()
{
    foreach (char item in messageArray)
    {
        Console.Write(item);
    }
    Console.Write(" ");
}*/
