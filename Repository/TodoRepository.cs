using AspNet.TODO.Models;

namespace AspNet.TODO.Repository
{
    public class TodoRepository
    {
        private static List<Todo> todo;

        public TodoRepository()
        {
            if(todo == null)
            {
                todo = new List<Todo>();
                TodoList();
            }
        }

        public List<Todo> GetList() { return todo; }

        private void TodoList()
        {
            Todo t1 = new Todo()
            {
                ID = 1,
                Title = "Obavi soping!",
                Date = new DateTime(2024, 1, 1)
            };
            todo.Add(t1);

            Todo t2 = new Todo()
            {
                ID = 2,
                Title = "Planiraj godisnji odmor",
                Date = new DateTime(2024, 3, 3)
            };
            todo.Add(t2);

            Todo t3 = new Todo()
            {
                ID = 3,
                Title = "Put na Cres",
                Date = new DateTime(2024, 8, 8)
            };
            todo.Add(t3);

            Todo t4 = new Todo()
            {
                ID = 4,
                Title = "Povratak na posao",
                Date = new DateTime(2024, 9, 9)
            };
            todo.Add(t4);

            Todo t5 = new Todo()
            {
                ID = 5,
                Title = "Sastanak s klijentima",
                Date = new DateTime(2024, 10, 10)
            };
            todo.Add(t5);
        }
    }
}
