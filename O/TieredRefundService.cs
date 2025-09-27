using solid.Shared;

namespace solid.O
{
    internal class TieredRefundService : IRefundableService
    {
        /// <summary>
        ///  Good example (Adheres to OCP) this class is closed for modification but open for extension
        /// </summary>
        /// <param name="percentage"></param>
        /// <returns></returns>
        public decimal CalculateRefundAmount(int percentage)
        {
            return percentage < 50 ? 100m : 200m;
        }
    }
}
