using MyTodoApp.Services;
using MyTodoApp.Services.Dtos;

namespace MyTodoApp.Pages;

public partial class TodoItems
{
    private readonly TodoAppService appService;

    string todoItemText;
    List<TodoItemDto> todoItems = new List<TodoItemDto>();

    public TodoItems(TodoAppService appService)
    {
        this.appService = appService;
    }

    public async Task SubmitAsync()
    {
        await appService.CreateAsync(todoItemText);
        todoItemText = string.Empty;
        await GetTodoItemsAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        await GetTodoItemsAsync();
    }

    private async Task GetTodoItemsAsync()
    {
        todoItems = await appService.GetListAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        await appService.DeleteAsync(id);
        await GetTodoItemsAsync();
    }
}
