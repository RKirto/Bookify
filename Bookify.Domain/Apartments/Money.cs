namespace Bookify.Domain.Apartments;

public record Money(decimal Amount, Currency Currency)
{
    public static Money operator +(Money first, Money second)
    {
        if (first.Currency != second.Currency)
        {
            throw new InvalidOperationException("currencies have to be equal");
        }

        return new Money(first.Amount + second.Amount, first.Currency);
    }

    public static Money zero() => new(0, Currency.None);
}