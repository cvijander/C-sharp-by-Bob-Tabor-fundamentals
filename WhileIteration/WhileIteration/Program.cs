// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("While iteration");

bool displayMenu = true;

while (displayMenu)
{
    displayMenu = MainMenu();
}



static bool MainMenu()
{
    Console.Clear();
    Console.WriteLine("Choose an option: ");
    Console.WriteLine("1) Print numbers");
    Console.WriteLine("2) Guessing game");
    Console.WriteLine("3) Exit");

    string result = Console.ReadLine();
    if(result =="1")
    {
        PrintNumbers();
        return true;
    }
    else if(result =="2")
    {
        GuessingGame();
        return true;
    }
    else if (result =="3")
    {
        return false;
    }
    else
    {
        return true ;
    }
            
    
}

static void PrintNumbers()
{
    Console.Clear() ;
    Console.WriteLine("Print numbers");
    Console.Write("Type a number: ");
    int result = int.Parse(Console.ReadLine());
    int counter = 1;
    while (counter < result + 1 )
    {
        Console.Write(counter);
        Console.Write("-");
        counter++;
    }
    Console.ReadLine();
}

static void GuessingGame()
{
    Console.Clear();
    Console.WriteLine("Guessing game");

    Random myRandom = new Random();
    int randomNumber = myRandom.Next(1, 11);

    int gueses = 0;

    bool incorect = true;
    do
    {
        Console.WriteLine("Guess the number between 1 and 10: ");
        string result = Console.ReadLine();
        gueses++;

        if(result == randomNumber.ToString())
        {
            incorect = false;
        }
        else
        {
            Console.WriteLine("Wrong");
        }
        


    } while (incorect);
    Console.WriteLine("Correct It took you {0} guesses",gueses);
    Console.ReadLine();
}
