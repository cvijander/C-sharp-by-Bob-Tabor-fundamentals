// See https://aka.ms/new-console-template for more information
Console.WriteLine("Simple classes ");



Car myCar = new Car();
myCar.Make = "Oldsmobile";
myCar.Model = "Cutlas Supreme";
myCar.Year = 1986;
myCar.Color = "Silver";

/*
decimal value= DeterminMarketValue(myCar);
*/

Console.WriteLine("{0:C}",myCar.DetermineMarketValue());

Console.WriteLine("{0} {1} {2} {3} ",myCar.Make, myCar.Model,myCar.Year,myCar.Color);
//Console.WriteLine("{0:C}",value);



static decimal DeterminMarketValue(Car car)
{
    decimal carValue = 100.0M;

    // someday i might look up the car 
    return carValue;

}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }


    public decimal DetermineMarketValue()
    {
        decimal carValue;
        if(Year > 1990)
        {
            carValue = 10000;
        }
        else
        {
            carValue = 2000;
        }

        return carValue;
    }

}


