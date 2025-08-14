namespace Product.Application;

using Product.Domain;

public sealed class ProductCreator(IProductRepository repository, ProductMatcher matcher)
{

    public async Task<Product> Create( Input input , CancellationToken ct)
    {
        var product = new Product
        {
            Id = input.Id,
            Sku = input.Sku,
            Name = input.Name,
            Price = input.Price,
            Stock = input.Stock
        };
        
        await repository.Create(product, ct);   
        return product;
    }

        public sealed record Input(string Id, string Sku, string Name, decimal Price, int Stock);

}