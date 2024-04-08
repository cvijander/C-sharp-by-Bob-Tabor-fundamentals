// See https://aka.ms/new-console-template for more information
using System.Net;

Console.WriteLine("Hello, World!");

WebClient client = new WebClient();
string reply = client.DownloadString("https://msdn.microsoft.com");

//File.WriteAllText(@"C:\Lesson17\WriteText.txt", reply);

Console.WriteLine(reply);