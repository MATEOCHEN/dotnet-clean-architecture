using Application.Common.Interfaces;
using Application.UseCase.TodoItem.Queries;
using Domain.Entities;
using FluentAssertions;
using MockQueryable.NSubstitute;

namespace Application.UnitTests;

[TestFixture]
public class GetTodoItemUnitTest
{
    private ITemplateContext _templateContext = null!;
    private GetTodoItemQueryHandler _handler = null!;

    [SetUp]
    public void SetUp()
    {
        _templateContext = Substitute.For<ITemplateContext>();
        _handler = new GetTodoItemQueryHandler(_templateContext);
    }

    [Test]
    public async Task get_todo_item_with_test()
    {
        GivenTodoItems([
            new TodoItem
            {
                Id = 0,
                TaskName = "let's codding",
                Done = false,
                CompleteOn = null,
                CreateOn = default,
                UpdateOn = null
            }
        ]);
        var result = await _handler.Handle(new GetTodoItemQuery(), new CancellationToken());

        result.Should().Be("get todo item with Name:let's codding");
    }

    private void GivenTodoItems(IEnumerable<TodoItem> todoItems)
    {
        var mock = todoItems.AsQueryable().BuildMockDbSet();
        _templateContext.TodoItems.Returns(mock);
    }
}