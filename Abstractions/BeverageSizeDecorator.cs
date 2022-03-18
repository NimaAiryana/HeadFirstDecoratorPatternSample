namespace HeadFirstDecoratorPatternSample.Abstractions
{
    public abstract class BeverageSizeDecorator : ABeverage
    {
        protected readonly ABeverage _beverage;

        public BeverageSizeDecorator(ABeverage beverage) => (_beverage, description) = (beverage, beverage.GetDescrption());
    }
}
