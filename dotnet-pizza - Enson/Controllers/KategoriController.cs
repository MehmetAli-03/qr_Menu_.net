using dotnet_pizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_pizza.Controllers
{
    public class KategoriController : Controller
    {
        private readonly DataContext _context;

        public KategoriController(DataContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var kategoriler = _context.Kategori.Include(i=>i.Products).ToList();

            return View(kategoriler);
        }
    }
}
