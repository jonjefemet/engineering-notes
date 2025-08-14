namespace Product.Application;

using Product.Domain;

public sealed class ProductSearcher(IProductRepository repository)
{

    public async Task<Product?> Search(string id, CancellationToken ct)
    {
        return await repository.Search(id, ct);
    }

}