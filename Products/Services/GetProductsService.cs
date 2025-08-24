using ProductsMicrosservice.Products.Models;

namespace ProductsMicrosservice.Products.Services;

public static class GetProductsService
{
    public static List<ProductModel> CreateProducts()
    {
        List<ProductModel> ProductsObjs = new();
        ProductsObjs.Add(new ProductModel(01, "IPhone", "A brand new Iphone", 2000, DateTime.Now));
        ProductsObjs.Add(new ProductModel(02, "Andoid Phone", "A brand new Android", 1000, DateTime.Now));
        ProductsObjs.Add(new ProductModel(03, "Notbook Gaming", "A brand new NoteBook", 2000, DateTime.Now));
        ProductsObjs.Add(new ProductModel(04, "IPhone", "A brand new Iphone", 2000, DateTime.Now));
        return ProductsObjs;
    }
}
