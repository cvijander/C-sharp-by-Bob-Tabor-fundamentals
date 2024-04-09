// See https://aka.ms/new-console-template for more information
Console.WriteLine("Handling Exceptions");

try
{
    string content = File.ReadAllText(@"C:\Lesson22\Example.txt");
    Console.WriteLine(content);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("There was a problem");
    Console.WriteLine("Make sure that the name of the file is named correctly");
}

catch (DirectoryNotFoundException ex)
{
    Console.WriteLine("There was a problem");
    Console.WriteLine("Make sure that the name of the directory is named correctly");
}


catch (Exception e)
{

    Console.WriteLine("Message : "+ e.Message);
}

finally
{
    Console.WriteLine("Closing aplication now...");
}

