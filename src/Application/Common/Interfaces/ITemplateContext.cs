using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface ITemplateContext
{
    DbSet<TodoList> TodoLists { get; set; }
    DbSet<TodoItem> TodoItems { get; set; }
}