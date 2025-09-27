using solid.Shared;

namespace solid.O
{
    internal class FlatRefundService : IRefundableService
    {
        public decimal CalculateRefundAmount(int percentage)
        {
            return 50m; // Flat refund amount
        }
    }
}
