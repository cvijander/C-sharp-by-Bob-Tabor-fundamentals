// See https://aka.ms/new-console-template for more information
using MyCodeLibrary;

Console.WriteLine("Hello, World!");


Scrape myScrape = new Scrape();
 string value = myScrape.ScrapeWebpage("http://msdn.microsoft.com");
Console.WriteLine(value);