using solid.Shared;

namespace solid.O
{
    public class PercentageRefundService : IRefundableService
    {
        /// <summary>
        /// Good example (Adheres to OCP)
        /// </summary>
        /// <param name="percentage"></param>
        /// <returns></returns>
        public decimal CalculateRefundAmount(int percentage)
        {
            return 1000m * (percentage / 100m); // e.g., base amount is 1000
        }

    }
}
