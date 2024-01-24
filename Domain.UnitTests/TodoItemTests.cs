using Domain.Entities;
using FluentAssertions;

namespace Domain.UnitTests;

[TestFixture]
public class TodoItemTests 
{
    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void todo_item_is_complete()
    {
        var todoItem = GivenTodoItem(new TodoItem
        {
            Id = 1,
            TaskName = "Give Steven a massage",
            Done = true,
            CompleteOn = new DateTime(2024,1,24),
            CreateOn = new DateTime(2024,1,20),
            UpdateOn = new DateTime(2024,1,24)
        });

        todoItem.IsComplete().Should().BeTrue();
    }

    private static TodoItem GivenTodoItem(TodoItem item)
    {
        return item;
    }
}