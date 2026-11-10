namespace Presentation.Services;

public class PriceInfoResult
{
    public decimal Price { get; }
    public bool IncludesVat { get; }
    public bool HasPrice { get; }

    public PriceInfoResult(decimal price, bool includesVat, bool hasPrice)
    {
        Price = price;
        IncludesVat = includesVat;
        HasPrice = hasPrice;
    }
}
