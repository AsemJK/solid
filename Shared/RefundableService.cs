namespace solid.Shared
{
    public class RefundableService : IRefundableService
    {

        /// <summary>
        /// Bad Example (Violates OCP)
        /// If you add new refund rules inside the same class, you’ll keep modifying RefundableService:
        /*
        public decimal CalculateRefundAmount(int percentage, string refundType = "perc")
        {
            if (refundType == "Percentage")
            {
                return 1000m * (percentage / 100m);
            }
            else if (refundType == "Flat")
            {
                return 50m;
            }
            else if (refundType == "Tiered")
            {
                return percentage < 50 ? 100m : 200m;
            }
            throw new InvalidEnumArgumentException("Invalid refund type");
        }
        */
        /// </summary>
        /// 

        //good example (Adheres to OCP)
        // we will add new classes that implement IRefundableService instead of modifying this class to add new refund types
        public decimal CalculateRefundAmount(int percentage)
        {
            throw new NotImplementedException();
        }
    }
}
