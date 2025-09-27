using solid.Shared;

namespace solid.L
{
    internal class OrderProcessor
    {
        private readonly IRefundableService _refundService;

        public OrderProcessor(IRefundableService refundService)
        {
            _refundService = refundService;
        }

        public decimal ProcessRefund(int percentage)
        {
            return _refundService.CalculateRefundAmount(percentage);
        }


        /*
         * 
         Client side Code
         IRefundableService service;

        // Regular refund
        service = new PercentageRefundService();
        Console.WriteLine(service.CalculateRefundAmount(20)); // 200

        // Special holiday refund
        service = new SpecialHolidayRefundService();
        Console.WriteLine(service.CalculateRefundAmount(20)); // 400
        public decimal ProcessRefund(decimal amount) {
        */
    }
}
