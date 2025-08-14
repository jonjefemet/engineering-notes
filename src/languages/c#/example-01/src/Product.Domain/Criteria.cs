namespace Product.Domain;

public enum Op { Eq, Ne, Gt, Gte, Lt, Lte, Contains, BeginsWith, In }

public sealed record Filter(string Field, Op Op, object? Value);
public sealed record Sort(string Field, bool Desc = false);

public sealed record Criteria(
    IReadOnlyList<Filter> Filters,
    IReadOnlyList<Sort>? Sorts = null,
    int? Skip = null,
    int? Take = null
);