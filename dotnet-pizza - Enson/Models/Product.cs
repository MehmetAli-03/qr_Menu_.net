namespace dotnet_pizza.Models;
public class Product
{
public int Id { get; set; }
public string ProductName { get; set; }=null!;
public string? Image { get; set; }
public string? Tanitim{get; set; }
public int? Price2 { get; set; }
public double  Price1 { get; set; }
 public int KategoriId { get; set; }
 public Kategori Kategori { get; set; }=null!;
}