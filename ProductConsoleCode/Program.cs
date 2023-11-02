// See https://aka.ms/new-console-template for more information
using ProductConsoleCode.Data;
using ProductConsoleCode.Models;
using System.ComponentModel;

Console.WriteLine("Hello, World!");

var db = new ProductContext();
db.Products.Add(new Product
{ 
    Price = 100m,
    Description = "A first console product"
});
db.Products.AddRange(new ProductConsoleCode.Models.Product { Price = 200m, Description = "Second Console Product" },
    new Product { Price = 140m, Description = "Third Console Product" }
    );

var count = db.SaveChanges();
Console.WriteLine($"{count} record count");

foreach( var items in db.Products)
{
    Console.WriteLine(items.GetText());
}