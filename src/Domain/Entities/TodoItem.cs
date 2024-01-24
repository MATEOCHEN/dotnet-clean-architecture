namespace Domain.Entities;

public class TodoItem
{
    public int Id { get; set; }
    public string TaskName { get; set; }
    public bool Done  { get; set; }
    public DateTime? CompleteOn  { get; set; }
    public DateTime CreateOn  { get; set; }
    public DateTime? UpdateOn  { get; set; }
}