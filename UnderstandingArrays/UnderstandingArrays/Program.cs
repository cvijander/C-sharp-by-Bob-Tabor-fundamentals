// See https://aka.ms/new-console-template for more information
Console.WriteLine("Working with arrays");

/*
int number1 =4;
int number2 = 8;
int number3 = 15;
int number4 = 16;
int number5 = 23;

if(number1 ==16)
{

}
else if(number2 ==16)
{
     
}
else if(number3 ==16)
{

}
*/


int[] numbers = new int[5];
numbers[0] = 4;
numbers[1] = 8;
numbers[2]= 15;
numbers[3] = 16;
numbers[4] = 23;

Console.WriteLine(numbers[1]);
Console.WriteLine("Here we have a " +numbers.Length+ " elements in our array.");

int[] newNumbers= new int[] { 4,8,12,15,16,23,45,78};

string[] names = new string[] { "Eddie", "Alex", "David Lee" ,"Michael"};

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}


foreach (string  name in names)
{
    Console.WriteLine(name);
}

string zig = "You can get what you want out of life if you help enought other people to get what they want";

char[] charArray  = zig.ToCharArray();
Array.Reverse(charArray);

foreach (char c in charArray)
{
    Console.Write(c);
}