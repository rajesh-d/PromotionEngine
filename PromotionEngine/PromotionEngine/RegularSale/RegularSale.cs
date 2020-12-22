namespace PromotionEngine
{
    public abstract class RegularSale : IPromotionSale
    {
        public abstract string ProductID { get; }
        public abstract decimal Price { get; }

        public decimal GetTotalPrice(int count)
        {
            return Price * count;
        }
    }
}
