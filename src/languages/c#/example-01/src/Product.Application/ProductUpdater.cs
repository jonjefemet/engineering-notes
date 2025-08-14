namespace Product.Application;

using Product.Domain;

public sealed class ProductUpdater(IProductRepository repository)
{
    public async Task Update(Input input, CancellationToken ct)
    {
        var current = await repository.Search(input.Id, ct) ?? throw new KeyNotFoundException();
        var updated = current with
        {
            Sku = input.Sku ?? current.Sku,
            Name = input.Name ?? current.Name,
            Price = input.Price ?? current.Price,
            Stock = input.Stock ?? current.Stock
        };
        await repository.Update(updated, ct);
    }

    public sealed record Input(string Id, string? Sku, string? Name, decimal? Price, int? Stock);

}