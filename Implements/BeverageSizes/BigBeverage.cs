using HeadFirstDecoratorPatternSample.Abstractions;

namespace HeadFirstDecoratorPatternSample.Implements.BeverageSizes
{
    public class BigBeverage : BeverageSizeDecorator
    {
        public BigBeverage(ABeverage beverage) : base(beverage)
        {
        }

        public override decimal Cost() => _beverage.Cost() + 20;
    }
}
