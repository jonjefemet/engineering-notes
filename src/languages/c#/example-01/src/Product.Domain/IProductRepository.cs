using System.Runtime.CompilerServices;

namespace Product.Domain;

public interface IProductRepository
{
    Task<Product?> Search(string id, CancellationToken ct);
    Task<IReadOnlyList<Product>> Match(Criteria criteria, CancellationToken ct);
    Task Create(Product product, CancellationToken ct);
    Task Update(Product product, CancellationToken ct);



}