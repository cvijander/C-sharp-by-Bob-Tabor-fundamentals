// See https://aka.ms/new-console-template for more information


using ScrapeLibrary;

Scrape myScrape = new Scrape();

string value = myScrape.ScrapeWebpage("https://msdn.microsoft.com");
Console.WriteLine(value);