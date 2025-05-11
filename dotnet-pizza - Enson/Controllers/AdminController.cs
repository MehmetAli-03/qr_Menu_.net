using Microsoft.AspNetCore.Mvc;

namespace dotnet_pizza.Controllers;
public class AdminController:Controller
{
    public ActionResult Index()
    {
        return View();
    }
    
}
