using System.Xml.Linq;

namespace HM102_ToDoList
{
    public class ToDoList
    {
        public List<Task> ItemsToDo { get; set; }

        public ToDoList()
        {
            ItemsToDo = new List<Task>();
        }
        // XDocument class: https://learn.microsoft.com/en-us/dotnet/standard/linq/xdocument-class-overview

        public void FindNotDoneItems()
        {
            var notDoneItems = ItemsToDo.Where(i =>!i.IsDone).ToList();
            XDocument doc = new XDocument(
                new XElement("Tasks",
                    notDoneItems.Select(task => new XElement("Task",
                        new XElement("Title", task.Title),
                        new XElement("Description", task.Description),
                        new XElement("DueDate", task.DueDate),
                        new XElement("IsDone", task.IsDone)))));
            doc.Save("NotDoneTasks.xml");
        }

        public void FindNextWeekItems()
        {
            var nextWeekItems = ItemsToDo.Where(i => i.DueDate >= DateTime.Now && i.DueDate <= DateTime.Now.AddDays(7)).ToList();
            XDocument doc = new XDocument(
                new XElement("Tasks",
                    from task in nextWeekItems
                    select new XElement("Task",
                        new XElement("Description", task.Description))));
            doc.Save("NextWeekTasks.xml");

        }
    }
}
