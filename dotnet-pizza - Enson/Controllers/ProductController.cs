using System.Threading.Tasks;
using dotnet_pizza.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_pizza.Controllers;

public class ProductController : Controller
{
    private readonly DataContext _context;

    public ProductController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        var urunler = _context.Products.ToList();
        return View(urunler);
    }

    public ActionResult List()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    public ActionResult Create()
    {
        ViewData["Kategoriler"] = _context.Kategori.ToList();
        return View();
    }

    [HttpPost]
public async Task<ActionResult> Create(ProductCreateModel model)
{
    string fileName;

    if (model.Image != null)
    {
        fileName = Path.GetRandomFileName() + ".jpg";
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);

        using (var stream = new FileStream(path, FileMode.Create))
        {
            await model.Image.CopyToAsync(stream);
        }
    }
    else
    {
        
        fileName = "amblem.png";
    }

    var entity = new Product()
    {
        ProductName = model.ProductName,
        Tanitim = model.Tanitim,
        Price1 = model.Price1,
        Price2 = model.Price2,
        KategoriId = model.KategoriId,
        Image = fileName
    };

    _context.Products.Add(entity);
    _context.SaveChanges();
    return RedirectToAction("Index");
}


    public ActionResult Edit(int id)
    {
        var entity = _context.Products.Select(i => new ProductEditModel
        {
            Id = i.Id,
            ProductName = i.ProductName,
            Tanitim = i.Tanitim,
            Price1 = i.Price1,
            Price2 = i.Price2,
            Image = i.Image,
            KategoriId = i.KategoriId,
        }).FirstOrDefault(i => i.Id == id);

        ViewData["Kategoriler"] = _context.Kategori.ToList();
        return View(entity);
    }

    [HttpPost]
    public ActionResult Edit(int id, ProductEditModel model)
    {
        if (id != model.Id)
        {
            return RedirectToAction("Index");
        }

        var entity = _context.Products.FirstOrDefault(i => i.Id == model.Id);
        if (entity != null)
        {
            entity.ProductName = model.ProductName;
            entity.Tanitim = model.Tanitim;
            entity.Price1 = model.Price1;
            entity.Price2 = model.Price2;
            entity.KategoriId = model.KategoriId;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        ViewData["Kategoriler"] = _context.Kategori.ToList();
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id)
    {
        var product = _context.Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }

        _context.Products.Remove(product);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult ByCategory(int id)
{
    var kategori = _context.Kategori.FirstOrDefault(k => k.Id == id);
    if (kategori == null)
        return NotFound();

    ViewBag.KategoriAdi = kategori.KategoriAdi;

    var products = _context.Products
        .Where(p => p.KategoriId == id)
        .ToList();

    return View("Index", products); // Index.cshtml ürün listesi görünümünü kullan
}

}
