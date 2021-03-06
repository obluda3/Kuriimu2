﻿using Kontract.Kompression;

namespace Kompression.Implementations.PriceCalculators
{
    public class Mio0PriceCalculator : IPriceCalculator
    {
        public int CalculateLiteralPrice(int value, int literalRunLength, bool firstLiteralRun)
        {
            return 9;
        }

        public int CalculateMatchPrice(int displacement, int length, int matchRunLength, int firstValue)
        {
            return 17;
        }
    }
}
