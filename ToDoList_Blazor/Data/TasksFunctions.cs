using Microsoft.EntityFrameworkCore;
using ToDoList_Blazor.Interfaces;

namespace ToDoList_Blazor.Data
{
    public class TasksFunctions : ITasksService
    {
        private readonly ApplicationDbContext _context;

        public TasksFunctions(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddTodoAsync(Todo todo)
        {
            await _context.Todos.AddAsync(todo);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTodoAsync(Todo todo)
        {
            var existingTodo = await _context.Todos.FindAsync(todo.Id);
            if (existingTodo != null)
            {
                existingTodo.Name = todo.Name;
                existingTodo.Date = todo.Date;
                existingTodo.Priority = todo.Priority;
                existingTodo.Status = todo.Status;
                existingTodo.Content = todo.Content;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteTodoAsync(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo != null)
            {
                _context.Todos.Remove(todo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Todo>> GetTodosAsync(string Id)
        {
            return await _context.Todos
                     .Where(t => t.UserId == Id)
                     .ToListAsync();
        }

        public async Task<Todo> GetTodoAsync(int id)
        {
            return await _context.Todos.FindAsync(id);
        }
    }
}