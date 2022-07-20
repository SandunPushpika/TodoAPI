using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApplication.DataAccess;
using TodoApplication.Models;

namespace TodoApplication.Services.TodoService {
    public class TodoService : ITodoService {
        private readonly DContext _context = new DContext();
        public Todo AddTodo(Todo todo) {
            _context.todos.Add(todo);
            _context.SaveChanges();
            return _context.Find<Todo>(todo.Id);
        }

        public void DeleteTodo(int todo_id) {
            var todo = _context.Find<Todo>(todo_id);
            _context.todos.Remove(todo);
            _context.SaveChanges();
        }

        public List<Todo> GetAllTodos(int user_id) {
            return _context.todos.Where(todo => todo.UserId == user_id).ToList();
        }

        public Todo UpdateTodo(Todo todo) {
            _context.Update(todo);
            _context.SaveChanges();
            return todo;
        }
    }
}
