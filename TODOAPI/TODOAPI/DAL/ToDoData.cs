using TODOAPI.Models;

namespace TODOAPI.DAL
{
    public class ToDoData
    {
        List<Todo> values = new List<Todo>();
        public ToDoData()
        {
            values.Add(new Todo { InternalId = 1, Id = 1, Description = "Good Morning", Title = "Morning" });
            values.Add(new Todo { InternalId = 2, Id = 2, Description = "Get Coffe", Title = "Evening" });
            values.Add(new Todo { InternalId = 3, Id = 3, Description = "Get Taxi", Title = "Night" });

        }
        public List<Todo> GetAllToDo() => values;        

        public List<Todo> AddToDo(string todo)
        {
            var count = values.Max(x => x.InternalId)+1;

            values.Add(new Todo
            {
                Title = todo,
                Description = todo,
                InternalId = count,
                Id = count
            }); ;

            return values;
            
        }
    }
}
