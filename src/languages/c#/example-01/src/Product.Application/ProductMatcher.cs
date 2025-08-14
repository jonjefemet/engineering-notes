namespace Product.Application;

using Product.Domain;

public sealed class ProductMatcher(IProductRepository repository)
{
    public async Task<IReadOnlyList<Product>> Match(Criteria criteria, CancellationToken ct)
    {
        return await repository.Match(criteria, ct);
    }
}