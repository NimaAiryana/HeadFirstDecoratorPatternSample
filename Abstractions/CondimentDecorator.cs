namespace HeadFirstDecoratorPatternSample.Abstractions
{
    public abstract class CondimentDecorator : ABeverage
    {
        protected readonly ABeverage _beverage;

        protected CondimentDecorator(ABeverage beverage) => (_beverage, description) = (beverage, beverage.GetDescrption());

        public abstract string GetDescirption();
    }
}
