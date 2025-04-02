// See https://aka.ms/new-console-template for more information
using To_Do_List;

LinkedList<TodoItem> tasks = new LinkedList<TodoItem>();

while (true)
{
    byte choice;
    Console.WriteLine("[1] Add Task, [2] View Tasks, [3] Remove Task, [4] Do Task, [5] Completed Tasks, [0] Exit");
    try { choice = byte.Parse(Console.ReadLine()); }
    catch { Console.WriteLine("Invalid choice"); continue; }
    if (choice == 0)
    {
        break;
    }
    else if (choice == 1)
    {
        AddTask(tasks);

    }
    else if (choice == 2)
    {
        DisplayTasks(tasks);
    }
    else if (choice == 3)
    {
        RemoveTask(tasks);
    }
    else if (choice == 4)
    {
        DoTask(tasks);
    }
    else if (choice == 5)
    {
        CompletedTasks(tasks);
    }
    else
    {
        Console.WriteLine("Invalid choice");
    }
}
static void AddTask(LinkedList<TodoItem> tasks){
    Console.WriteLine("Write the task:");
    TodoItem item = new TodoItem(Console.ReadLine());
    tasks.AddLast(item);
}

static void DisplayTasks(LinkedList<TodoItem> tasks)
{
    int count = 0;
    foreach (TodoItem task in tasks)
    {
        Console.WriteLine("[{0}] {1} {2}", count, task.Title, task.IsDone ? "o" : "x");
        count++;
    }
}

static void RemoveTask(LinkedList<TodoItem> tasks)
{
    Console.WriteLine("Which task at which index do you weant to remove");
    int index;
    try { index = int.Parse(Console.ReadLine()); }
    catch { Console.WriteLine("Invalid index"); return; }
    int listLenght = tasks.Count;
    if (index < listLenght)
    {
        tasks.Remove(tasks.ElementAt(index));
    }
    else
    {
        Console.WriteLine("Invalid index");
    }
}

static void DoTask(LinkedList<TodoItem> tasks)
{
    Console.WriteLine("Which task at which index do you want to mark as done?");
    int index;
    try { index = int.Parse(Console.ReadLine()); }
    catch { Console.WriteLine("Invalid index"); return; }
    int listLenght = tasks.Count;
    if (index < listLenght)
    {
        tasks.ElementAt(index).MarkAsDone();
    }
    else
    {
        Console.WriteLine("Invalid index");
    }
}

static void CompletedTasks(LinkedList<TodoItem> tasks)
{
    int count = 0;
    tasks.Where(task => task.IsDone).ToList().ForEach(task =>
    {
        Console.WriteLine("[{0}] {1}", count, task.Title);
        count++;
    });
    Console.WriteLine("Comleted tasks: {0}", count);
}