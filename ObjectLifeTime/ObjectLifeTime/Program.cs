// See https://aka.ms/new-console-template for more information
Console.WriteLine("Object lifetime ");


Car myCar = new Car();
Car myThirdCar = new Car("Ford", "Escape", 2005, "White");


/*
myCar.Make = "Oldsmobile";
myCar.Model = "Cutlas Supreme";
myCar.Year = 1986;
myCar.Color = "Silver";
*/


Car myOtherCar;
myOtherCar = myCar;

//myOtherCar.Model = "98";

Console.WriteLine("{0} {1} {2} {3}",myOtherCar.Make,myOtherCar.Model,myOtherCar.Year,myOtherCar.Color);
myOtherCar.Model = "98";
Console.WriteLine("Now my Car");
Console.WriteLine("{0} {1} {2} {3}",myCar.Make,myCar.Model,myCar.Year,myCar.Color);
Console.WriteLine("{0} {1} {2} {3}",myThirdCar.Make,myThirdCar.Model,myThirdCar.Year,myThirdCar.Color);

//myOtherCar = null;




class Car
{
    public string Make { get;set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }


    public Car()
    {
        Make = "Nissan";
    }

    public Car (string make, string model, int year, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
    }

}