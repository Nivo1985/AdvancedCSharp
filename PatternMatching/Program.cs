// See https://aka.ms/new-console-template for more information

using PatternMatching;
using PatternMatching.Demos;

var demosTypePattern = new DemosTypePattern();
demosTypePattern.Demo1();
demosTypePattern.Demo2();

var demosSwitchExpression = new DemoSwitchExpression();
demosSwitchExpression.Demo1();

var demosPositionalPattern = new PositionalPattern();
demosPositionalPattern.Demo1();
demosPositionalPattern.Demo2();


var demosPropertyPattern = new DemosPropertyPattern();
demosPropertyPattern.Demo1();
demosPropertyPattern.Demo2();

Console.ReadKey();