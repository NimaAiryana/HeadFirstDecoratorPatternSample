using HeadFirstDecoratorPatternSample.Abstractions;

namespace HeadFirstDecoratorPatternSample.Implements.Beverages
{
    public class HouseBlend : ABeverage
    {
        public HouseBlend() => description = nameof(HouseBlend);

        public override decimal Cost() => .89M;
    }
}
