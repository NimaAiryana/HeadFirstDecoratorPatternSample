using HeadFirstDecoratorPatternSample.Abstractions;

namespace HeadFirstDecoratorPatternSample.Implements.BeverageSizes
{
    public class SmallBeverage : BeverageSizeDecorator
    {
        public SmallBeverage(ABeverage beverage) : base(beverage)
        {
        }

        public override decimal Cost() => _beverage.Cost() + 5;
    }
}
