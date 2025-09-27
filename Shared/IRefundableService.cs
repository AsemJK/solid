namespace solid.Shared
{
    public interface IRefundableService
    {
        /// <summary>
        /// Bad Example (Violates OCP)
        /*
        decimal CalculateRefundAmount(int percentage, string refundType = "perc");
        */
        /// </summary>

        //good example (Adheres to OCP)
        decimal CalculateRefundAmount(int percentage);
    }
}
