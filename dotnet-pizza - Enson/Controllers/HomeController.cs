using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnet_pizza.Models;

public class HomeController : Controller
{
    private readonly DataContext _context;

    public HomeController(DataContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var products = _context.Products.Include(p => p.Kategori).ToList();

        var model = new HomeViewModel
        {
            Pizzas = products.Where(p => p.KategoriId == 1).ToList(),
            Citirs = products.Where(p => p.KategoriId == 2).ToList(),
            Burgers = products.Where(p => p.KategoriId == 3).ToList(),
            Iceceks = products.Where(p => p.KategoriId == 4).ToList(),
            Boreks = products.Where(p => p.KategoriId == 5).ToList(),
            Atistirmaliks = products.Where(p => p.KategoriId == 6).ToList(),
            Tosts = products.Where(p => p.KategoriId == 7).ToList()
        };

        return View(model);
    }
}
