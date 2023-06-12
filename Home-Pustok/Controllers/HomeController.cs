using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokTemplateTask.DAL;
using PustokTemplateTask.Models;
using PustokTemplateTask.ModelViews;

namespace PustokTemplateTask.Controllers
{
    public class HomeController:Controller
    {
        private readonly PustokDbContext context;

        public HomeController(PustokDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            ICollection<Slider> Sliders = context.Sliders.ToArray();
         
            PustokVM model = new()
            {
                  Sliders = Sliders,   
            };
            return View(model);
        }
    }
}
