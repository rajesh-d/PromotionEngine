using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class PromotionSalePriceA : PromotionSale
    {
        public override string ProductID { get; } = "A";
        public override decimal PricePerOne { get; } = 50;
        public override decimal PricePerX { get; } = 130;
        public override int X { get; } = 3;
    }
}
