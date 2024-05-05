using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNet.TODO.Models;
using AspNet.TODO.Repository;

namespace AspNet.TODO.Controllers
{
    public class TodoController : Controller
    {
        private TodoRepository _todo;

        public TodoController()
        {
            _todo = new TodoRepository();
        }
        public ActionResult Index()
        {
            var TodoList = _todo.GetList();
            return View(TodoList);
        }
    }
}
