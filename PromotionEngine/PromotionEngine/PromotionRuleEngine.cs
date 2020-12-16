using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class PromotionRuleEngine
    {
        private List<IPromotionSale> _promotionSales;

        public PromotionRuleEngine(List<IPromotionSale> promotionSales)
        {
            _promotionSales = promotionSales;
        }
        public decimal GetTotalAmount(List<string> products)
        {
            decimal totalAmount = 0;
            foreach (var promotionSale in _promotionSales)
            {
                var productList = products.Where(x => x == promotionSale.ProductID);
                totalAmount += promotionSale.GetTotalPrice(productList.Count());
            }

            return totalAmount;
        }
    }
}
