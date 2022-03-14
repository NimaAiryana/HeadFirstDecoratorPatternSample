using HeadFirstDecoratorPatternSample.Abstractions;

namespace HeadFirstDecoratorPatternSample.Implements.Beverages
{
    public class Espresso : ABeverage
    {
        public Espresso() => description = nameof(Espresso);

        public override decimal Cost() => 1.99M;
    }
}
