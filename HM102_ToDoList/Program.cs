namespace HM102_ToDoList
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            ToDoList toDoList = new ToDoList();
            toDoList.ItemsToDo.Add(new Task { Title = "Read a book", Description = "Read chapter 7 of \"The Pragmatic programmer\"", DueDate = DateTime.Now.AddDays(1), IsDone = false });
            toDoList.ItemsToDo.Add(new Task { Title = "Plant vegetables", Description = "Plant zucchini, tomatoe and bell-pepper plants", DueDate = DateTime.Now.AddDays(2), IsDone = true });
            toDoList.ItemsToDo.Add(new Task { Title = "Vaccination appointment", Description = "Make appointment with a vet to vaccinate the cat", DueDate = DateTime.Now.AddDays(3), IsDone = false });
            toDoList.ItemsToDo.Add(new Task { Title = "Meet friend", Description = "Call a friend and agree to meet", DueDate = DateTime.Now.AddDays(4), IsDone = true });
            toDoList.ItemsToDo.Add(new Task { Title = "Collect berries", Description = "Collect raspberries and blueberies from the garden", DueDate = DateTime.Now.AddDays(5), IsDone = false });

            toDoList.FindNotDoneItems();
            toDoList.FindNextWeekItems();
        }
    }
}