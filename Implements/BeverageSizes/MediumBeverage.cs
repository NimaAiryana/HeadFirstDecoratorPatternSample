using HeadFirstDecoratorPatternSample.Abstractions;

namespace HeadFirstDecoratorPatternSample.Implements.BeverageSizes
{
    public class MediumBeverage : BeverageSizeDecorator
    {
        public MediumBeverage(ABeverage beverage) : base(beverage)
        {
        }

        public override decimal Cost() => _beverage.Cost() + 10;
    }
}
