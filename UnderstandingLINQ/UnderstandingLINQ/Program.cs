﻿// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Understanding LINQ");




List<Car> myCars = new List<Car>()
{
     new Car(){ VIN="A1", Make="BMW", Model="550i",StickerPrice=55000, Year =2009},
     new Car() { VIN="B2", Make ="Toyota", Model ="4Runner", StickerPrice=35000, Year =2010},
     new Car() {VIN ="C3", Make ="BMW", Model ="745li", StickerPrice=75000, Year =2008},
     new Car() {VIN="D4", Make ="Ford" , Model ="Escape", StickerPrice=25000, Year =2008},
     new Car() { VIN ="E5", Make="BMW", Model ="55i", StickerPrice=57000, Year=2010}
};

//LINQ query 
/*
var bmws = from car in myCars
           where car.Make == "BMW"
           && car.Year ==2010
           select car;

*/
/*
var orderedCars = from car in myCars
                  orderby car.Year descending
                  select car;
*/
// LINK method
// lamba expression 
//var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

// var orderedCars = myCars.OrderByDescending(p => p.Year);

/*
var firstBmw = myCars.OrderByDescending(p=>p.Year). First(p => p.Make == "BMW");

Console.WriteLine(firstBmw.VIN);
*/

// Console.WriteLine(myCars.TrueForAll(p=>p.Year >2007));

//myCars.ForEach(p => Console.WriteLine("{0} {1:C} ", p.VIN, p.StickerPrice));

/*
myCars.ForEach(p => p.StickerPrice -= 3000);
myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));
*/

//Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

//Console.WriteLine(myCars.Sum(p=>p.StickerPrice));

Console.WriteLine(myCars.GetType());
/*
foreach (var car in orderedCars)
{
    Console.WriteLine("{0} {1} {2}", car.Year, car.Model, car.VIN);
}
*/
class Car
{
    public string VIN { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public double StickerPrice { get; set; }
    public int Year { get; set; }
}
