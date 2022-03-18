using HeadFirstDecoratorPatternSample.Abstractions;

namespace HeadFirstDecoratorPatternSample.Implements.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(ABeverage beverage) : base(beverage) { }

        public override decimal Cost() => _beverage.Cost() + .2M;
    }
}
