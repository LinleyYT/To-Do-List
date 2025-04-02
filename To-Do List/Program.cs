// See https://aka.ms/new-console-template for more information
LinkedList<string> tasks = new LinkedList<string>();

while (true)
{
    byte choice;
    Console.WriteLine("[1] Add Task, [2] View Tasks, [3] Remove Task, [0] Exit");
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
    else
    {
        Console.WriteLine("Invalid choice");
    }
}

static void AddTask(LinkedList<string> tasks){
    Console.WriteLine("Write the task:");
    tasks.AddLast(Console.ReadLine());
}

static void DisplayTasks(LinkedList<string> tasks)
{
    int count = 0;
    foreach (string task in tasks)
    {
        Console.WriteLine("[{0}] {1}", count, task);
        count++;
    }
}

static void RemoveTask(LinkedList<string> tasks)
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