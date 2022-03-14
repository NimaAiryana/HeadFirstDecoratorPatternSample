﻿using HeadFirstDecoratorPatternSample.Abstractions;

namespace HeadFirstDecoratorPatternSample.Implements.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(ABeverage beverage) : base(beverage) { }

        public override string GetDescirption() => _beverage.GetDescrption();

        public override decimal Cost() => _beverage.Cost() + .10M;
    }
}
