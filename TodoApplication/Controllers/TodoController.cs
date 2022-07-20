using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TodoApplication.Models;
using TodoApplication.Services.Models;
using TodoApplication.Services.TodoService;

namespace TodoApplication.Controllers {
    [Route("api/{userid}/todos")]
    [ApiController]
    public class TodoController : Controller {
        private readonly ITodoService _service;
        private readonly IMapper _mapper;

        public TodoController(ITodoService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetTodos(int userid) {
            var mappedTodo = _mapper.Map<ICollection<TodoModel>>(_service.GetAllTodos(userid));
            return Ok(mappedTodo);
        }

        [HttpPost]
        public IActionResult AddTodo(int userid, Todo todo) {
            todo.UserId = userid;
            var newtodo = _service.AddTodo(todo);

            return Created("created todo",newtodo);
        }

        [HttpPut]
        public IActionResult EditTodo(int userid, Todo todo) {
            _service.UpdateTodo(todo);
            return NoContent();
        }

        [HttpDelete("/{todoId}")]
        public IActionResult DeleteTodo(int userid, int todoId) {
            _service.DeleteTodo(todoId);
            return NoContent();
        }

    }
}
