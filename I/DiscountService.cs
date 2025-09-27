namespace solid.I
{
    internal class DiscountService : IDiscountable
    {
        public DiscountService()
        {

        }
        public decimal ApplyDiscount(decimal amount, int percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentOutOfRangeException(nameof(percentage), "Percentage must be between 0 and 100.");
            return amount - (amount * percentage / 100);
        }
        /*
         interface IRefundableService is small and focused (only one method).
        Clients aren’t forced to implement or depend on unused members.
        This follows ISP well.
         
         */
    }
}
