using Microsoft.AspNetCore.Mvc;
using MVC_Project.Core.Interfaces;
using MVC_Project.Core.Models;

namespace MVC_Project.web.Controllers
{
    public class MenuController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
            public MenuController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        
       
       
    }
}
