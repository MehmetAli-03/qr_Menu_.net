using Microsoft.EntityFrameworkCore;

namespace dotnet_pizza.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Kategori> Kategori { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Kategori>().HasData(
            new List<Kategori>() {
                new Kategori { Id = 1,KategoriAdi="Pizza"},
                new Kategori { Id = 2,KategoriAdi="Citir"},
                new Kategori { Id = 3,KategoriAdi="Burger"},
                new Kategori { Id = 4,KategoriAdi="Icecek"},
                new Kategori { Id = 5,KategoriAdi="Borek"},
                new Kategori { Id = 6,KategoriAdi="Atistirmalik"},
                new Kategori { Id = 7,KategoriAdi="Tost"},
            }
        );
        
        modelBuilder.Entity<Product>().HasData(
            new List<Product>() 
            { 
                new Product() { Id = 1, ProductName = "Pizza2",  Tanitim = "sucuklu,kaşarli", Price1=260,Price2=320,Image="pizza.jpg",KategoriId=1 },
                new Product() { Id = 2, ProductName = "Pizza2",  Tanitim = "sucuklu,kaşarli", Price1=260,Price2=320,Image="pizza.jpg",KategoriId=1 },
                new Product() { Id = 3, ProductName = "Pizza4",  Tanitim = "sucuklu,kaşarli", Price1=260 ,Price2=320,Image="pizza.jpg",KategoriId=1},
                new Product() { Id = 4, ProductName = "Pizza5",  Tanitim = "sucuklu,kaşarli", Price1=260,Price2=320,Image="pizza.jpg",KategoriId=1},
                new Product() { Id = 5, ProductName = "Pizza6",  Tanitim = "sucuklu,kaşarli", Price1=260,Price2=320 ,Image="pizza.jpg",KategoriId=1},
                new Product() { Id = 6, ProductName = "Burger1",  Tanitim = "tavuk Burger", Price1=260,Image="burger.jpg",KategoriId=3},
                new Product() { Id = 7, ProductName = "Burger2",  Tanitim = "tavuk Burger", Price1=250,Image="burger.jpg",KategoriId=3},
                new Product() { Id = 8, ProductName = "Burger3",  Tanitim = "tavuk Burger", Price1=240,Image="burger.jpg",KategoriId=3},
                new Product() { Id = 9, ProductName = "Çıtır1",  Tanitim = "tavuk Burger", Price1=230,Image="burger2.jpg",KategoriId=2},
                new Product() { Id = 20, ProductName = "Çıtır2",  Tanitim = "tavuk Burger", Price1=230,Image="burger2.jpg",KategoriId=2},
                new Product() { Id = 10, ProductName = "Börek1",  Tanitim = "tavuk Burger", Price1=260,KategoriId=5},
                new Product() { Id = 11, ProductName = "Tost2",  Tanitim = "tavuk Burger", Price1=260,KategoriId=7},
                new Product() { Id = 12, ProductName = "İçecek1", Price1=260,KategoriId=4},
                new Product() { Id = 13, ProductName = "Atistirmalik1", Price1=260,KategoriId=6},

            }  
        );
    }
}
