using Volo.Abp.Domain.Entities;

namespace MyTodoApp.Entities;

public class TodoItem : AggregateRoot<Guid>
{
    public string Text { get; set; }
}
