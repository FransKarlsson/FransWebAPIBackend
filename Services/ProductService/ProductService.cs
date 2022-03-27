using System;
using System.Collections.Generic;
using System.Linq;
using dotnetProjekt.Models;

namespace dotnetProjekt.Services.ProductService
{
    public class ProductService : IProductService
    {

        private static List<Product> productList = new List<Product>()
        {
            new Product() {title = "Jar of loop" ,ID = 1, rating = 4, cost = 200, stock = 50, description = "A jar containing goop"},

            new Product() {title = "Jar of goop", ID = 2, rating = 4, cost = 200, stock = 50, description = "A jar containing goop"}
        };

        public List<Product> GetProductList()
        {
            return _context.products.ToList();
        }

        private readonly DataContext _context;


        public ProductService(DataContext context)
        {
            _context = context;
        }




        public List<Product> Deleteproduct(int id)
        {
            var foundProduct = _context.products.FirstOrDefault(product => product.ID == id);
            _context.products.Remove(foundProduct);
            _context.SaveChanges();
            return _context.products.ToList();
        }

        public List<Product> Updateproduct(Product updateProduct)
        {
            var foundProduct = _context.products.FirstOrDefault(Product => Product.ID == updateProduct.ID);
            if (foundProduct != null)
            {
                foundProduct.title = updateProduct.title;
                foundProduct.description = updateProduct.description;
            }
            _context.SaveChanges();
            return _context.products.ToList();
        }

        public List<Product> Addproduct(Product newProduct)
        {
            _context.products.Add(newProduct);
            _context.SaveChanges();
            return _context.products.ToList();
        }
    }

}
