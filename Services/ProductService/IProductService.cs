using System.Collections.Generic;
using dotnetProjekt.Models;

namespace dotnetProjekt.Services.ProductService
{
    public interface IProductService
    {
        List<Product> GetProductList();
        List<Product> Addproduct(Product newProduct);
        List<Product> Deleteproduct(int id);
        List<Product> Updateproduct(Product updateProduct);
    }
}
