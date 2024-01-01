var myMoney = new Money(1000, "JPY");
var allowance = new Money(3000, "JPY");
Money result = myMoney.Add(allowance);
Console.WriteLine(result.amount);

var jpy = new Money(1000, "JPY");
var usd = new Money(100, "USD");

Money result2 = jpy.Add(usd);


class Money
{
    public readonly decimal amount;
    public readonly string currency;

    public Money(decimal amount, string currency)
    {
        if (currency == null) throw new ArgumentNullException(nameof(currency));
        this.amount = amount; 
        this.currency = currency;
    }

    public Money Add(Money arg)
    {
        if (arg == null) throw new ArgumentNullException(nameof(arg));
        if (currency != arg.currency) throw new ArgumentException($"通貨単位が異なります (this:{currency}, arg:{arg.currency})");
        return new Money(amount + arg.amount, currency);
    }
}