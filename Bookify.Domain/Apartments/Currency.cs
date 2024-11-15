namespace Bookify.Domain.Apartments;

public record Currency
{
    internal static readonly Currency None = new("");
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("EUR");

    private Currency(string code) => code = code;

    public string Code { get; init; }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(c => c.Code == code) ??
               throw new ApplicationException("the currency code is invalid");
    }

    public static readonly IReadOnlyCollection<Currency> All = new[] { Usd, Eur };

}