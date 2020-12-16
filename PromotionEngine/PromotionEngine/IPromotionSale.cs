namespace PromotionEngine
{
    public interface IPromotionSale
    {
        string ProductID { get; }
        decimal GetTotalPrice(int count);
    }
}
