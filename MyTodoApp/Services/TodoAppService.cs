using MyTodoApp.Entities;
using MyTodoApp.Services.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyTodoApp.Services;

public class TodoAppService : ApplicationService
{
    private readonly IRepository<TodoItem> _repository;
    public TodoAppService(IRepository<TodoItem> repository)
    {
        _repository = repository;
    }

    public async Task<List<TodoItemDto>> GetListAsync()
    {
        var todoItems = await _repository.GetListAsync();

        return todoItems.Select(x => new TodoItemDto
        {
            Id = x.Id,
            Text = x.Text,
        }).ToList();
    }

    public async Task CreateAsync(string text)
    {
        await _repository.InsertAsync(new TodoItem
        {
            Text = text,
        });
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(x => x.Id == id);
    }
}
