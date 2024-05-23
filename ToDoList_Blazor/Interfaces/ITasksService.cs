using ToDoList_Blazor.Data;

namespace ToDoList_Blazor.Interfaces
{
    public interface ITasksService
    {
        Task AddTodoAsync(Todo todo);
        Task UpdateTodoAsync(Todo todo);
        Task DeleteTodoAsync(int id);
        Task<List<Todo>> GetTodosAsync(string Id);
        Task<Todo> GetTodoAsync(int id);
    }
}