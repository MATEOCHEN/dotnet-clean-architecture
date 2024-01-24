namespace Domain.Entities;

public class TodoList
{
    public string Name { get; set; }
    public List<TodoItem> Items { get; set; }
}