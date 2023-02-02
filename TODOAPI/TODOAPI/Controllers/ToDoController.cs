using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TODOAPI.Models;
using TODOAPI.Service;

namespace TODOAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private ToDoService _toDoService;

        public ToDoController()
        {
            //Note: Not a good practise below, we should use DI
            _toDoService = new ToDoService();
        }

        [HttpGet]
        public List<Todo> GetAll() => _toDoService.GetTodos();

  
        [HttpPost]
        public List<Todo> PostTodo([FromBody] string todo) =>  _toDoService.AddTodos(todo);

        [HttpDelete]
        public void Delete(int id)
        {
            //values.Remove(id);
        }

    }
}
