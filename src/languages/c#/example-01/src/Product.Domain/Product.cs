namespace Product.Domain;

public sealed record Product
{
    public string Id { get; init; } = default!;
    public string Sku { get; init; } = default!;
    public string Name { get; init; } = default!;
    public decimal Price { get; init; }
    public int Stock { get; init; }
}