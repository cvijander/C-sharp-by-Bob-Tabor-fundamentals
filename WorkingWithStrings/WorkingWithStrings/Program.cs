// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Working with strings");


// escape caracters \"  sada mogu da se koriste navodnici tekstu
//string myString = "My \"so-called\" life";

// new line   \n - za novi red
//string myString = "What if I need a\n new line?";


//string myString = "Go to your c:\\drive";

//string myString = String.Format("{0} = {1}", "First", "Second");

//string myString = String.Format("{0:C}", 123.45);

//string myString = String.Format("{0:N}", 1234567890);

//string myString = String.Format("{0:P}", .123);

// string myString = String.Format("{0:(###) ###-####}", 1234567890);

//string myString = " That summer we took threes across the board  ";

//myString = myString.Substring(6);

//myString =myString.ToUpper();

//myString = myString.Replace(" ", " --");

//myString = myString.Remove(6,14);

/*
myString = String.Format("Length before {0} -- Length after {1}", myString.Length, myString.Trim().Length);

myString = myString.Trim();

*/

/*
string myString = "";

for (int i = 0; i < 100; i++)

{
    myString += "--" + i.ToString();
}
*/

StringBuilder myBuilder = new StringBuilder();

for (int i = 0; i < 100; i++)
{
    myBuilder.Append("--");
    myBuilder.Append(i);
}


Console.WriteLine(myBuilder);
Console.ReadLine();


