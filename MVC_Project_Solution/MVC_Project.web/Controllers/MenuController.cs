using Microsoft.AspNetCore.Mvc;
using MVC_Project.Core.Interfaces;

namespace MVC_Project.web.Controllers
{
    public class MenuController : Controller
    {
        //private readonly IBaseRepository<T> -TRepository;
        //    public MenuController(IBaseRepository<T> TRepository)
        //{
        //    _tr
        //}


        public IActionResult Index()
        {
            return View();
        }
    }
}
