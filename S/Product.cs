namespace solid.S
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// This method calculates the refundable amount based on the given percentage.
        /// This method breaks the Single Responsibility Principle (SRP) because the Product class should only be responsible for product-related properties and behaviors.
        /// 
        public decimal CalculateRefundableAmount(int percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percentage), "Percentage must be between 0 and 100.");
            }
            return Price * percentage / 100;
        }
        /// </summary>
    }
}
