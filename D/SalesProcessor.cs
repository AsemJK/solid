using solid.Shared;

namespace solid.D
{
    internal class SalesProcessor
    {
        private readonly IRefundableService _refundableService;

        public SalesProcessor(IRefundableService refundableService)
        {
            _refundableService = refundableService;
        }
        /// <summary>
        /// Since your business logic can depend on IRefundableService instead of RefundableService, higher-level modules don’t need to know the concrete implementation.
        /// Here SalesProcessor depends on the abstraction (IRefundableService) and not the concrete RefundableService. This makes testing and swapping implementations easy.
        /// </summary>
        /// <param name="refundPercentage"></param>
        /// <returns></returns>
        public decimal ProcessSale(int refundPercentage)
        {
            // Some sales logic here...
            decimal saleAmount = 1000m; // Example sale amount
            // Calculate potential refund using the injected service
            decimal refundAmount = _refundableService.CalculateRefundAmount(refundPercentage);
            // Final amount after considering refund
            return saleAmount - refundAmount;


        }
    }
}
