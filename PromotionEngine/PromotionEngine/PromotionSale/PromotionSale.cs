using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public abstract class PromotionSale
    {
        public abstract string ProductID { get; }
        public abstract decimal PricePerOne { get; }
        public abstract decimal PricePerX { get; }
        public abstract int X { get; }
    }
}
