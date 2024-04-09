// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enums and switch");



List<Todo> todos = new List<Todo>()
{
    new Todo {Description ="Task 1", EstimatedHours =6, Status =Status.NotStarted },
    new Todo {Description ="Task 2", EstimatedHours =2, Status =Status.OnHold },
    new Todo {Description ="Task 3", EstimatedHours =8, Status =Status.InProgress },
    new Todo {Description ="Task 4", EstimatedHours =12, Status =Status.NotStarted },
    new Todo {Description ="Task 5",EstimatedHours =6, Status =Status.NotStarted },
    new Todo {Description ="Task 6", EstimatedHours =2, Status =Status.Completed },
    new Todo {Description ="Task 7", EstimatedHours =14, Status =Status.NotStarted },
    new Todo {Description ="Task 8", EstimatedHours =8, Status =Status.InProgress },
    new Todo {Description ="Task 9", EstimatedHours =8, Status =Status.Completed },
    new Todo {Description ="Task 10", EstimatedHours =10, Status =Status.Deleted },
    new Todo {Description ="Task 11", EstimatedHours =6, Status =Status.InProgress },
    new Todo {Description ="Task 12", EstimatedHours =4, Status =Status.OnHold},
    new Todo {Description ="Task 13", EstimatedHours =3, Status =Status.NotStarted },
    new Todo {Description ="Task 14", EstimatedHours =7, Status =Status.Completed },
    new Todo {Description ="Task 15", EstimatedHours =9, Status =Status.InProgress },
    new Todo {Description ="Task 16", EstimatedHours =11, Status =Status.NotStarted },
    new Todo {Description ="Task 17", EstimatedHours =5, Status =Status.OnHold },
    new Todo {Description ="Task 18", EstimatedHours =3, Status =Status.NotStarted },
    new Todo {Description ="Task 19", EstimatedHours =1, Status =Status.Deleted },

};



PrintAssesment(todos);
Console.ReadLine();


static void PrintAssesment(List<Todo> todos)
{
    foreach (var todo in todos)
    {
        switch (todo.Status)
        {
            case Status.NotStarted:
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                break;
            case Status.InProgress:
                Console.ForegroundColor = ConsoleColor.Green;

                break;
            case Status.OnHold:
                Console.ForegroundColor = ConsoleColor.Yellow;

                break;
            case Status.Completed:
                Console.ForegroundColor = ConsoleColor.Black;

                break;
            case Status.Deleted:
                Console.ForegroundColor = ConsoleColor.Red;

                break;
            default:
                break;
        }
        Console.WriteLine(todo.Description);
    }
}


class Todo
{
    public string Description { get; set; }
    public int EstimatedHours { get; set; }
    public Status Status { get; set; }

}


enum Status
{
    NotStarted,
    InProgress,
    OnHold,
    Completed,
    Deleted

}