using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApplication.Models;

namespace TodoApplication.Services.TodoService {
    public interface ITodoService {
        public List<Todo> GetAllTodos(int user_id);
        public Todo AddTodo(Todo todo);
        public Todo UpdateTodo(Todo todo);
        public void DeleteTodo(int user_id);

    }
}
