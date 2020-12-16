using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public abstract class PromotionSale : IPromotionSale
    {
        public abstract string ProductID { get; }
        public abstract decimal PricePerOne { get; }
        public abstract decimal PricePerX { get; }
        public abstract int X { get; }

        public decimal GetTotalPrice(int count)
        {
            if (count == 0)
            {
                return 0;
            }

            decimal result = 0;

            while (count >= X)
            {
                result += PricePerX;
                count -= X;
            }

            return result + (PricePerOne * count);
        }
    }
}
