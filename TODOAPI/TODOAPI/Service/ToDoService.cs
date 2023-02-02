using Newtonsoft.Json.Linq;
using TODOAPI.DAL;
using TODOAPI.Models;

namespace TODOAPI.Service
{
    public class ToDoService
    {
        private ToDoData _data;

        public ToDoService()
        {
            //Note: Not a good practise below, we should use DI
             _data = new ToDoData();
           
        }

        public List<Todo> GetTodos() => _data.GetAllToDo();

        public List<Todo> AddTodos(string todo) => _data.AddToDo(todo);
        
    }
       
}
