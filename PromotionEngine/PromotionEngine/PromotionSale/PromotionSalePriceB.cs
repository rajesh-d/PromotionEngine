using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class PromotionSalePriceB : PromotionSale
    {
        public override string ProductID { get; } = "B";
        public override decimal PricePerOne { get; } = 30;
        public override decimal PricePerX { get; } = 45;
        public override int X { get; } = 2;
    }
}
