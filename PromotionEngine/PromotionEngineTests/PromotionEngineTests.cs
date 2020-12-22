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

        [TestMethod]
        public void Promotion_OneA_OneB_OneC_Is100()
        {
            var promotionEngine = new PromotionRuleEngine(GetPromotionPricingRules());
            var products = new List<string>
            {
                "A","B","C"
            };
            var totalAmount = promotionEngine.GetTotalAmount(products);

            Assert.AreEqual(100, totalAmount);
        }

        [TestMethod]
        public void Promotion_FiveA_FiveB_OneC_Is370()
        {
            var promotionEngine = new PromotionRuleEngine(GetPromotionPricingRules());
            var products = new List<string>
            {
                "A","B","C","A","B","A","B","A","B","A","B"
            };
            var totalAmount = promotionEngine.GetTotalAmount(products);

            Assert.AreEqual(370, totalAmount);
        }

        [TestMethod]
        public void Promotion_OneA_OneB_OneC_OneD_Is280()
        {
            var promotionEngine = new PromotionRuleEngine(GetPromotionPricingRules());
            var products = new List<string>
            {
                "A","B","C","D"
            };
            var totalAmount = promotionEngine.GetTotalAmount(products);

            Assert.AreEqual(115, totalAmount);
        }

        private List<IPromotionSale> GetPromotionPricingRules()
        {
            return new List<IPromotionSale>()
            {
                new PromotionSalePriceA(),
                new PromotionSalePriceB(),
                new RegularSalePriceC(),
                new RegularSalePriceD()
            };
        }
    }
}
