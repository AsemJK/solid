using solid.Shared;

namespace solid.L
{
    internal class SpecialHolidayRefundService : IRefundableService
    {
        /*
         Reminder of LSP
        Objects of a superclass (or interface) should be replaceable with objects of a subclass (or implementation) without breaking the correctness of the program.
        */
        public decimal CalculateRefundAmount(int percentage)
        {
            var baseAmount = 1000m * (percentage / 100m);
            return baseAmount * 2; // double refund for special holiday
        }
    }
}
