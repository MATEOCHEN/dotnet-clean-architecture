using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class TemplateContext : DbContext, ITemplateContext
{
    public TemplateContext() { }

    public TemplateContext(DbContextOptions<TemplateContext> options)
        : base(options) { }

    public virtual DbSet<TodoList> TodoLists { get; set; }
    public virtual DbSet<TodoItem> TodoItems { get; set; }
}
