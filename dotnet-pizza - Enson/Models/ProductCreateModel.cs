namespace dotnet_pizza.Models;

public class ProductCreateModel
{

public string ProductName { get; set; }=null!;
public IFormFile?Image { get; set; }
public string? Tanitim{get; set; }
public int? Price2 { get; set; }
public double  Price1 { get; set; }
public int KategoriId { get; set; }
}