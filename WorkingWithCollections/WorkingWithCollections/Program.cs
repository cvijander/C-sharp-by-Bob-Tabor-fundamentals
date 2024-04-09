// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("working with collections ");

/*
Car car1 =new Car();
car1.Make = "Oldsmobile";
car1.Model = "Cutlas Supreme";
car1.VIN = "1234";


Car car2 =new Car();
car2.Make = "Geo";
car2.Model = "Prism";
car2.VIN = "2345";

Book b1 = new Book();
b1.Author = "Rober Tabor";
b1.Title = "Microsoft";
b1.ISBN = "0-00-000-00";

// Array list are dinamically sized 
// cool feature sorting, remove items
// 

/*
ArrayList arrayList = new ArrayList();
arrayList.Add(b1);
arrayList.Add(car1);
arrayList.Add(car2);
arrayList.Remove(b1);

foreach (Car car  in arrayList)
{
    Console.WriteLine(car.Make);
}
*/
/*

// List<T>

List<Car> myList = new List<Car>();
myList.Add(car1);
    myList.Add(car2);
//myList.Add(b1);

foreach (Car car in myList)
{
    Console.WriteLine(car.Model);
}

/*
// Dictionary<Tkey,TValue> 

Dictionary<string,Car> myDictionary = new Dictionary<string,Car>();

myDictionary.Add(car1.VIN, car1);
myDictionary.Add(car2.VIN, car2);

Console.WriteLine(myDictionary["2345"].Make);
*/

/*
string[] names = { "Bob", "Steve", "Brian", "Chuck" };

*/
/*  object initiazlier  
 *  no need for a constructor
Car car1=new Car() { Make="BMW", Model ="750",VIN="C3"};

Car car2 = new Car { Make = "Toyota", Model = "4Runner", VIN = "D4" };
*/

// collection initializer 
List<Car> myList = new List<Car>()
{
    new Car{ Make ="Oldsmobile",Model ="Cutlas suporeme",VIN="E5"},
    new Car{ Make ="Nissan", Model="Altima",VIN ="F6"}
};



class Car
{
    public string VIN { get;set; }
    public string Make { get;set; }
    public string Model { get; set; }
}

class Book
{
    public string Author { get;set; }
    public string Title { get;set; }
    public string ISBN  { get;set; }
}


