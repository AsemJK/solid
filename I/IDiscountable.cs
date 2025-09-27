namespace solid.I
{
    internal interface IDiscountable
    {
        decimal ApplyDiscount(decimal amount, int percentage);
    }
}
