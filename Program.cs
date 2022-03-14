using HeadFirstDecoratorPatternSample.Abstractions;
using HeadFirstDecoratorPatternSample.Implements.Beverages;
using HeadFirstDecoratorPatternSample.Implements.Condiments;

Console.WriteLine("Hello, Decoartor Pattern :D");
Console.WriteLine();
Console.WriteLine();

ABeverage espresso = new Espresso();
Console.WriteLine($"{espresso.GetDescrption()} default price is {espresso.Cost()}");

Console.WriteLine("-----------------------------");

Console.WriteLine("please add double mocha and soy to my espresso");
espresso = new Mocha(espresso);
espresso = new Mocha(espresso);
espresso = new Soy(espresso);

Console.WriteLine($"And now {espresso.GetDescrption()} price is {espresso.Cost()}");
