namespace HeadFirstDecoratorPatternSample.Abstractions
{
    public abstract class ABeverage
    {
       protected string description = "Unknown Beverage";

        public string GetDescrption() => description;

        public abstract decimal Cost();
    }
}
