namespace ProductsMicrosservice.Products.Models;

public class ProductModel
{
    public ProductModel(int id, string productName, string prodcutDescription, decimal price, DateTime expirationDate)
    {
        Id = id;
        ProductName = productName;
        ProdcutDescription = prodcutDescription;
        Price = price;
        ExpirationDate = expirationDate;
    }

    public int Id { get; set; }
    public string ProductName { get; set; }
    public string ProdcutDescription { get; set; }
    public decimal Price { get; set; }
    public DateTime ExpirationDate { get; set; }
}
