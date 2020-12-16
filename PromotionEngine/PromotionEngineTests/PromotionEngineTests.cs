using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System.Collections.Generic;

namespace PromotionEngineTests
{
    [TestClass]
    public class PromotionEngineTests
    {
        [TestMethod]
        public void Promotion_WhenNoProducts_PriceIsZero()
        {
            var promotionEngine = new PromotionRuleEngine(GetPromotionPricingRules());
            var products = new List<string>();

            var totalAmount = promotionEngine.GetTotalAmount(products);

            Assert.AreEqual(0, totalAmount);
        }

        [TestMethod]
        public void Promotion_OneA_OneB_Is80()
        {
            var promotionEngine = new PromotionRuleEngine(GetPromotionPricingRules());
            var products = new List<string>
            {
                "A","B"
            };
            var totalAmount = promotionEngine.GetTotalAmount(products);

            Assert.AreEqual(80, totalAmount);
        }

        [TestMethod]
        public void Promotion_ThreeA_ThreeB_Is205()
        {
            var promotionEngine = new PromotionRuleEngine(GetPromotionPricingRules());
            var products = new List<string>
            {
                "A","A","A","B","B","B"
            };
            var totalAmount = promotionEngine.GetTotalAmount(products);

            Assert.AreEqual(205, totalAmount);
        }
        private List<IPromotionSale> GetPromotionPricingRules()
        {
            return new List<IPromotionSale>()
            {
                new PromotionSalePriceA(),
                new PromotionSalePriceB(),
            };
        }
    }
}
