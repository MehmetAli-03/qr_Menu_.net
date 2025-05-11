namespace dotnet_pizza.Models;

public class Kategori
{
    public int Id { get; set; }

    public string KategoriAdi { get; set; }=null!;

    public List<Product> Products { get; set; }=new(); 
}
